//PLAYEREN SKAL HAVE DETTE SCRIPT FOR AT KUNNE BEVÆGE SIG IMELLEM SCENER!!!

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDOL : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

}
