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
        // Hvis der skal tilf�jes flere poster til scenen, skal de tilf�jes her. De skal ogs� laves p� selve scenen
        // Der g�res ved at lave et object, kald det et tal som ikke allerade er i arrayet. her efter laver du et emty
        // gameobject og tilf�jer det til arrayet. Husk at �ndre navnet p� det nye object til det tal du har valgt. og giv det en boxcollider
        // emty gameobjectet skal have en ontrigger effet. de skal begge ogs� have tagget pop
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
