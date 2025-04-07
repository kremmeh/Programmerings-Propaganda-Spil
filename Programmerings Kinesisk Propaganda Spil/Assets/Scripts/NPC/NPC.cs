using System.Collections;
using System.Collections.Generic;
using Assets.Scenes.Btest;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;


public class NPC : MonoBehaviour
{
    
    public GameObject prefab;
    public TextMeshProUGUI text;
    dataScript data;
    void Start()
    {
        // her istansiere vi det ScriptableObject
        data = ScriptableObject.CreateInstance<dataScript>();
        

    }
    public void Interact()
    {
       this.gameObject.GetComponent<AIRandomMovement>().startTalking();
        prefab.SetActive(true);
        text.text = "" + data.dText[GetComponent<Collider>().gameObject.name];
    }

    public void StopInteract() { 
    
        this.gameObject.GetComponent<AIRandomMovement>().stopTalking();
        prefab.SetActive(false);
    }

   
}
