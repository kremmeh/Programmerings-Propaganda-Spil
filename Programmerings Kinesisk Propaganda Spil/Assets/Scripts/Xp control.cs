using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//til teksten
using TMPro;
using UnityEngine.UI;

public class Xpcontrol : MonoBehaviour
{
    //serializefield so u can see them in the inspector
    [SerializeField] private TextMeshProUGUI level;
    [SerializeField] private TextMeshProUGUI xpText;
    [SerializeField] private int Level;
    [SerializeField] private Image XpProgressBar;

    [SerializeField] private float TargetXp;
    //public så man har adgang til den i andre scripts, hvis man skal hente xp
    //de andre er private da de ikke behøver at blive tilgået fra andre scripts
    public float CurrentXp;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            CurrentXp += 12;
        }

        xpText.text = CurrentXp + " / " + TargetXp;
        ExperienceController();
    }


    public void ExperienceController()
    {
        level.text = "Level : " + Level.ToString();
        //Kontrollere fill amount
        XpProgressBar.fillAmount = (CurrentXp / TargetXp);

        if (CurrentXp >= TargetXp) //level up
        {
            //tager sig af overflow af xp, hvis goal var på 10, og man får 12 xp, så rykker de 2 sidste hen til level 2
            CurrentXp = CurrentXp - TargetXp;
            Level++;
            TargetXp += 50;
        }
    }
}

