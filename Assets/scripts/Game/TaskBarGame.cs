using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TaskBarGame : MonoBehaviour
{
    public int Technology;
    public Text TechnologyText;
    public int Design;
    public Text DesignMText;
    public int Gameplay;
    public Text GameplayText;
    public Animator anim;
    void Start()
    {

    }


    public void UpdateTaks()
    {
        TechnologyText.text = Technology.ToString();
        DesignMText.text = Design.ToString();
        GameplayText.text = Gameplay.ToString();
        anim.SetBool("Vibration", true);

    }
    public void StopUpdateTaks()
    {

        anim.SetBool("Vibration", false);

    }
}
