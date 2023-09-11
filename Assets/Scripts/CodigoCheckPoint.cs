using System.Collections;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;

public class CodigoCheckPoint : MonoBehaviour
{

    
    public GameObject CheckPointManager;
    [SerializeField] Vector3 posicioncheck;
    // Start is called before the first frame update
    void Start()
    {
        posicioncheck = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) {
            CheckPointManager.GetComponent<CheckPointManager>().RegistrarPosicionCheck(transform.position);
            //Debug.Log(transform.position);
            gameObject.SetActive(false);
        }
    }

}
