using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PuntosPlayer : MonoBehaviour
{

    public int puntosPlayerActual;
   
    
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void puntos(int puntosRecividos ) {
        puntosPlayerActual += puntosRecividos;
    }
}
