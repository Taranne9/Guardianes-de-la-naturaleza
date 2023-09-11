using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuntosRecargasManager : MonoBehaviour
{

    [SerializeField] GameObject Player, bombillo;

       [SerializeField] int puntosAcargar;
        bool isRecargar;
        Animator animator;
       
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && isRecargar )
        {

            Debug.Log("Recarga");
            animator.SetTrigger("Luz");
            Player.GetComponent<PuntosPlayer>().puntosPlayerActual = 0;
          

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player")){

            if (other.GetComponent<PuntosPlayer>().puntosPlayerActual >= puntosAcargar) {
                isRecargar = true;
                Debug.Log("Tiene5Puntos");
            }
            
            bombillo.SetActive(true);
            Debug.Log("Player Cerca");
           
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isRecargar = false;
            bombillo.SetActive(false);
            Debug.Log("Player Lejos");
        }
    }
}
