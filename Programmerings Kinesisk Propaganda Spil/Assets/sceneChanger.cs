//SKAL BRUGES HVER GANG SPILLEREN SKAL KUNNE SKIFTE SCENE!!!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    public string loadScene;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadScene);
        }
    }
} 