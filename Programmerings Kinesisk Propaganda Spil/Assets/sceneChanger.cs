//SPiller karakteren SKAL have dette script for at kunne teleporte imellem scenerne

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("tp")){
            int temp = int.Parse(other.gameObject.name.Substring(2));
            SceneManager.LoadScene(temp);
        }
        
    }
}
