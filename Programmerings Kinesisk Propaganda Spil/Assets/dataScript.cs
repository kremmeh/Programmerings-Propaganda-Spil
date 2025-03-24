using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataScript : ScriptableObject
{

    public Hashtable dText = new Hashtable();
   
    // Start is called before the first frame update
    void Awake()
    {
        // Brug dText.Add("Key", "String") til at tilføje ny tekst eller dialog eller ligende
        dText.Add("1", "Hej");
        dText.Add("2", "Daniel er sej");

       // Debug.Log(dText["1"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
