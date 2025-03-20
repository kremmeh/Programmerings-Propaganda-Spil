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
        t[0].SetActive(false);
        t[1].SetActive(false);
        t[2].SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
      
  

    }

    public void OnTriggerStay(Collider other)
    {
       
        if (Input.GetMouseButtonDown(0))
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
