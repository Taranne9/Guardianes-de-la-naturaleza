using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CheckPointManager : MonoBehaviour
{
    [SerializeField] Vector3 posicionCheckTransform;
    [SerializeField] GameObject player, panelRevivePlayer, puntoInicial;
    [SerializeField] float tiempoReinicio;
    
    
    // Start is called before the first frame update
    void Start()
    {
        if (tiempoReinicio <= 0) { tiempoReinicio = 5; }
        player = GameObject.FindWithTag("Player");
        posicionCheckTransform = puntoInicial.transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void RegistrarPosicionCheck(Vector3 T)
    {
        posicionCheckTransform = T;
     
    }


    public void personajeMuere(bool EstadoVida) {
        if (EstadoVida) {            
            StartCoroutine(RevivePlayer());
        }
    }


    IEnumerator RevivePlayer() {
       
        panelRevivePlayer.SetActive(true);
        yield return new WaitForSeconds(tiempoReinicio);
        player.GetComponent<VidaPlayer>().vidaActualPlayer = 10;
        panelRevivePlayer.SetActive(false);
        player.transform.position = posicionCheckTransform;
        
        
        
    }



}
