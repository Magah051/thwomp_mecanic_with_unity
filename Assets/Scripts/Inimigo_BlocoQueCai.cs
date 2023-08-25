using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_BlocoQueCai : MonoBehaviour
{

    [Header("Referências gerais")]
    private Rigidbody2D oRigidbody2D;

    [Header("Queda do inimigo")]
    [SerializeField] private float forcaDaGravidade;
    private bool podeCair;
    private bool caiu;


    [Header("Subida do inimigo")]
    [SerializeField] private float velocidadeDeSubida;
    [SerializeField] private float tempoMaximoParaSubir;
    private float tempoAtualParSubir;
    private Vector3 posicaoInicial;



    private void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();

    }


    // Start is called before the first frame update
    private void Start()
    {
        podeCair = false;
        caiu = false;
        oRigidbody2D.gravityScale = 0f;

        posicaoInicial = transform.position;
        tempoAtualParSubir = tempoMaximoParaSubir;

    }

    private void Update()
    {
        RodarCronometro();
    }

    private void RodarCronometro()
    {
        if (caiu)
        {
            tempoAtualParSubir -= Time.deltaTime;

            if (tempoAtualParSubir <= 0)
            {
                caiu = false;
                oRigidbody2D.gravityScale = 0f;
                tempoAtualParSubir = tempoMaximoParaSubir;
            }
        }
        else
        {
            if (transform.position != posicaoInicial)
            {
                transform.position = Vector3.MoveTowards(transform.position, posicaoInicial, velocidadeDeSubida * Time.deltaTime);
                podeCair = false;
            }
            else
            {
                podeCair = true;
            }
        }
    }

    public void AtivarGravidade()
    {
        if (podeCair)
        {
            caiu = true;
            oRigidbody2D.gravityScale = forcaDaGravidade;
        }

    }
}
