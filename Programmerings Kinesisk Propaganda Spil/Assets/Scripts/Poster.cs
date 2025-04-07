using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poster : MonoBehaviour
{
    bool isActive = false;
    public GameObject[] t;
    // Start is called before the first frame update
    void Start()
    {
        // Hvis der skal tilføjes flere poster til scenen, skal de tilføjes her. De skal også laves på selve scenen
        // Der gøres ved at lave et object, kald det et tal som ikke allerade er i arrayet. her efter laver du et emty
        // gameobject og tilføjer det til arrayet. Husk at ændre navnet på det nye object til det tal du har valgt. og giv det en boxcollider
        // emty gameobjectet skal have en ontrigger effet. de skal begge også have tagget pop
        t[0].SetActive(false);
        t[1].SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
      
  

    }

    public void OnTriggerStay(Collider other)
    {
       
        if (Input.GetKeyDown(KeyCode.E))
        {
            
            if (other.gameObject.CompareTag("pop"))
            {
                int temp = int.Parse(other.gameObject.name);
                isActive = !isActive;
                t[temp].SetActive(isActive);

            }

        }
    }
}
