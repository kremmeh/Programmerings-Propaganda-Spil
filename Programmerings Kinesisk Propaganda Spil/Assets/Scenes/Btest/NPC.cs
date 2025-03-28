using System.Collections;
using System.Collections.Generic;
using Assets.Scenes.Btest;
using Unity.Collections.LowLevel.Unsafe;
using UnityEngine;
using UnityEngine.AI;

public class NPC : MonoBehaviour
{
    
    public void Interact()
    {
       this.gameObject.GetComponent<AIRandomMovement>().startTalking();
        Debug.Log("Stop!");
    }

    public void StopInteract() { 
    
        this.gameObject.GetComponent<AIRandomMovement>().stopTalking();
    
    }
}
