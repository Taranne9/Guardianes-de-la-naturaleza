using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoSiguePlayer : MonoBehaviour
{
    [SerializeField] int velocidadEnemigo;
    [SerializeField] GameObject player;
    [SerializeField] GameObject enemigo;
    [SerializeField] bool enemigoSiguePlayer;
    [SerializeField] GameObject puntoReposo;


    // Start is called before the first frame update
    void Start()
    {
        if (velocidadEnemigo <= 0) { velocidadEnemigo = 10; }
    }

    // Update is called once per frame
    void Update()
    {
        if(enemigoSiguePlayer)
        {

            enemigo.transform.position = Vector3.MoveTowards(enemigo.transform.position, player.transform.position, velocidadEnemigo*Time.deltaTime);
        }

        if (!enemigoSiguePlayer)
        {
            if (enemigo.transform.position != transform.position)
            {
                enemigo.transform.position = Vector3.MoveTowards(enemigo.transform.position, puntoReposo.transform.position, velocidadEnemigo / 3 * Time.deltaTime);
            }
            else {
                enemigo.transform.position = puntoReposo.transform.position;
            }
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) { 
            enemigoSiguePlayer=true;
          
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Enemigo"))
        {
            enemigoSiguePlayer = false;

        }
    }

}
