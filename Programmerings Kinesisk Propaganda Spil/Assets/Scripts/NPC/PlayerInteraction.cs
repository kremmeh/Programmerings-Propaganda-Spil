using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
   
    public bool isInteracting = false;
    public GameObject prefab;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float interactRange = 2f;
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out NPC npcInteractable))
                {
                    if (!isInteracting)
                    {
                        npcInteractable.Interact();
                        isInteracting = true;
                       
                    }else {
                        npcInteractable.StopInteract();
                        isInteracting = false;
                    }
                }


            }

        }
    }
}
