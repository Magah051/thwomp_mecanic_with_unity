using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativador_BlocoQueCai : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            transform.root.GetComponent<Inimigo_BlocoQueCai>().AtivarGravidade();

        }
    }
}
