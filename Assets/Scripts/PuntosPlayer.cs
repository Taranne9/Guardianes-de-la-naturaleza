using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class PuntosPlayer : MonoBehaviour
{

    public int puntosPlayerActual;
    public TMP_Text TextoPuntos;
    public TMP_Text TextoPuntos1;


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
        TextoPuntos.text = puntosPlayerActual.ToString();
        TextoPuntos1.text = puntosPlayerActual.ToString();
    }
}
