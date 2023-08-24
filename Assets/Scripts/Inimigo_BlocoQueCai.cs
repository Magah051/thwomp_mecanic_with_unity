using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo_BlocoQueCai : MonoBehaviour
{

    private Rigidbody2D oRigidbody2D;

    [SerializeField] private float forcaDaGravidade;
    
    [SerializeField] private float velocidadeDeSubida;

    [SerializeField] private float tempoMaximoParaSubir;

    private float tempoAtualParSubir;
    
    private Vector3 posicaoInicial;

    private bool podeCair;
    private bool caiu;

    private void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();

    }


    // Start is called before the first frame update
    void Start()
    {
        podeCair = false;
        caiu = false;
        oRigidbody2D.gravityScale = 0f;

        posicaoInicial = transform.position;
        tempoAtualParSubir = tempoMaximoParaSubir;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            podeCair = true;
            AtivarGravidade();
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
