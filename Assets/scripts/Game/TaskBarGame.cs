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

    public int ProchentCreateGameInt;
    public Text ProchentCreateGame;
    public Animator anim;
    public GameObject TaskBar;
    public CreatingGameSistem CreatingGameSistem;

    void Start()
    {

    }


    public void UpdateTaks()
    {
        TechnologyText.text = Technology.ToString();
        DesignMText.text = Design.ToString();
        GameplayText.text = Gameplay.ToString();
        anim.SetBool("Vibration", true);
        ProchentCreateGame.text = ProchentCreateGameInt +"%";
        if(ProchentCreateGameInt >= 100)
        {
            CreatingGameSistem.StopGameCreate();
        }
    }
    public void StopUpdateTaks()
    {

        anim.SetBool("Vibration", false);

    }
    public void SetActiveTaskBar()
    {
        TaskBar.SetActive(true);
    }
    public void SetDisActiveTaskBar()
    {
        TaskBar.SetActive(false);
    }


}
