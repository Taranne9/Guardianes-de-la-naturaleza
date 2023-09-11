using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VidaPlayer : MonoBehaviour
{
    public int vidaActualPlayer;
    [SerializeField] int vidaTotalPlayer;
    [SerializeField] GameObject checkPointManager;
    // Start is called before the first frame update
    void Start()
    {
        if (vidaTotalPlayer <= 0) { vidaTotalPlayer = 100; }
        vidaActualPlayer = vidaTotalPlayer;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BajarVidaPlayer(int dañoRecibido)
    {
        vidaActualPlayer -= dañoRecibido;
        if (vidaActualPlayer <= 0) {
            checkPointManager.GetComponent<CheckPointManager>().personajeMuere(true);
           
        }

    }
}
