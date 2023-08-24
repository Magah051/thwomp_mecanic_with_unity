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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
