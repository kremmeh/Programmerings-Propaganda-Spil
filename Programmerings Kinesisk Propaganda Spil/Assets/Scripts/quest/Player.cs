using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 5;
    public int experience = 10;
    public int gold = 100;


    public Quest quest;



    public void GoBattle()
    {
        health -= 1;
        experience += 2;
        gold += 5;



        if (quest.isActive)
        {
            quest.goal.PostersUp();
            if (quest.goal.IsReached())
            {
                experience += quest.experienceReward;
                gold += quest.goldReward;
                quest.Complete();
            }

        }



    }




}

