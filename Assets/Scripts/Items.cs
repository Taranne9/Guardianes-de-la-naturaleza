using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Items : MonoBehaviour
{

    [SerializeField] int puntos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            other.gameObject.GetComponent<PuntosPlayer>().puntos(puntos);
            Debug.Log("hit items");
            Destroy(gameObject);
        }

    }
}
