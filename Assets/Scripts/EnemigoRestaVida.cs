using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoRestaVida : MonoBehaviour
{
    [SerializeField] int dañoAtaque;

    private void Start()
    {
        if (dañoAtaque <= 0) { dañoAtaque = 10; }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {

            other.gameObject.GetComponent<VidaPlayer>().BajarVidaPlayer(dañoAtaque);
            Debug.Log("Le quito vida al player--Trigger");
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {

            collision.gameObject.GetComponent<VidaPlayer>().BajarVidaPlayer(dañoAtaque);
            Debug.Log("Le quito vida al player--Collider");
        }
    }


}
