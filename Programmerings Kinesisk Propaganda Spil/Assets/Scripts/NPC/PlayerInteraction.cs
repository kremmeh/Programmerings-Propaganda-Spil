using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
   
    public bool isInteracting = false;
    private NPC currentNPC = null;
    private float interactRange = 2f;
    private float leaveRange = 4f;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            Collider[] colliderArray = Physics.OverlapSphere(transform.position, interactRange);
            foreach (Collider collider in colliderArray)
            {
                if (collider.TryGetComponent(out NPC npcInteractable))
                {
                    if (!isInteracting)
                    {
                        npcInteractable.Interact();
                        isInteracting = true;
                        currentNPC = npcInteractable;

                    }
                    else {
                        npcInteractable.StopInteract();
                        isInteracting = false;
                        currentNPC = null;
                    }
                    break;
                }


            }

        }
        if (isInteracting && currentNPC != null)
        {
            float distance = Vector3.Distance(transform.position, currentNPC.transform.position);
            if (distance > leaveRange)
            {
                currentNPC.StopInteract();
                isInteracting = false;
                currentNPC = null;
            }
        }
    }
}

