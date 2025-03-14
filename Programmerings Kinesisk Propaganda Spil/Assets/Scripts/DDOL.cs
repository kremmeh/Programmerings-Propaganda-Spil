//PLAYEREN SKAL HAVE DETTE SCRIPT FOR AT KUNNE BEVÆGE SIG IMELLEM SCENER!!!

using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class DDOL : MonoBehaviour
{
   public  GameObject prefab;
   private GameObject player;

    private void Awake()
    {
        if(GameObject.Find("Player") == null){

            player = Instantiate(prefab,this.transform.position,quaternion.identity);
            player.name = "Player";
        }

        DontDestroyOnLoad(player);
    }

}
