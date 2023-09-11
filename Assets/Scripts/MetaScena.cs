using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MetaScena : MonoBehaviour
{
     public  int nextScene;

    private void OnTriggerEnter(Collider other) {
        if(other.CompareTag("Player")){
            SceneManager.LoadScene(nextScene);
            Debug.Log("hit Scene");
        }
    }
}
