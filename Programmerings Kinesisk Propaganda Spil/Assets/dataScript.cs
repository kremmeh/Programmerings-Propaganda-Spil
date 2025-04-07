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
        // ["Key"] skal være det samme tal som nummeret i arrayet i Poster.cs
        dText.Add("0", "Poster has been placed");
        dText.Add("1", "Quang has been hit");
        dText.Add("Npc 1", "you are gay");
        dText.Add("Npc 2", "you are yag");

       // Debug.Log(dText["1"]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
