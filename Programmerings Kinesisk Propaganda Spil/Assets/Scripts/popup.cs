using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class popup : MonoBehaviour
{
    bool isActive = false;
    public GameObject prefab;
    public TextMeshProUGUI text;
    dataScript data;
    // Start is called before the first frame update
    void Start()
    {
        // her istansiere vi det ScriptableObject
        data = ScriptableObject.CreateInstance<dataScript>();
        prefab.gameObject.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // laver en function til at g�re n�r man tr�der ind i en collider kan man klikke p� musen for at f� dialog boxen til at poppe op
    public void OnTriggerStay(Collider other)
    {
        

        if (Input.GetKeyDown(KeyCode.E))
        {
            
            if (other.gameObject.CompareTag("pop"))
            {
               
                prefab.gameObject.SetActive(true);
                text.text = "" + data.dText[other.GetComponent<Collider>().gameObject.name];
                isActive = !isActive;
                prefab.gameObject.SetActive(isActive);
            }

        }
        
    }
    public void OnTriggerExit(Collider other)
    {
        prefab.gameObject.SetActive(false);
    }
}
