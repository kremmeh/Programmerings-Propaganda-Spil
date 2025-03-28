using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{
    //deathCount kan ændres til alt der skal kunne gemmes
    public int deathCount;
    public Vector3 playerPosition;

    // the value defined in this constructor will be the default values
    // the game starts with when there's no data to Load
    public GameData()
    {
        this.deathCount = 0;
        playerPosition = Vector3.zero;
    }
}
