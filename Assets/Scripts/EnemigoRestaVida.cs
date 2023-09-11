using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoRestaVida : MonoBehaviour
{
    [SerializeField] int da�oAtaque;

    private void Start()
    {
        if (da�oAtaque <= 0) { da�oAtaque = 10; }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {

            other.gameObject.GetComponent<VidaPlayer>().BajarVidaPlayer(da�oAtaque);
            Debug.Log("Le quito vida al player--Trigger");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<VidaPlayer>().BajarVidaPlayer(da�oAtaque);
            Debug.Log("Le quito vida al player--Collider");
        }
    }


}
