using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class ActivadorCamara : MonoBehaviour
{

    [SerializeField] GameObject camara;
    [SerializeField] float tiempoVidacamara;
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
        if (other.CompareTag("Player")) {
            Debug.Log("hit");
           camara.SetActive(true);

            StartCoroutine(AcivarCamara());
        }
    }


    IEnumerator AcivarCamara() {
        yield return new WaitForSeconds(tiempoVidacamara);
        camara.SetActive(false);
        Destroy(gameObject);
        Debug.Log("destruido");

    }
}
