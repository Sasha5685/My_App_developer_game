using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CreatingGameSistem : MonoBehaviour
{
    public Animator animSetCreateGame;
    public GameObject BackGroundSetings;
    public GameObject VarianCreate;
    public GameObject EndGameCreate;
    public TaskBarGame TaskBarGame;
    public TMP_InputField NameGame;
    public int ÑomplexityGameCreate = 1;
    public Text NameGameText;
    public string NameGameString;
    public bool IsCreate;

    public void ClouseCreateGame()
    {
        animSetCreateGame.SetBool("IsCreating", false);
        NameGame.text = "";
        NameGameString = "";
    }
    public void OpenCreateGame()
    {

        BackGroundSetings.SetActive(true);
        VarianCreate.SetActive(false);
        animSetCreateGame.SetBool("IsCreating", true);
    }
    public void SaveInputText()
    {
        NameGameString = NameGame.text;

    }
    public void CreateGame()
    {
        if(NameGameString == "")
        {

        }
        else
        {
            animSetCreateGame.SetBool("IsCreating", false);
            IsCreate = true;
            TaskBarGame.SetActiveTaskBar();
        }

    }
    public void StopGameCreate()
    {
        IsCreate = false;
        EndGameCreate.SetActive(true);
        TaskBarGame.SetDisActiveTaskBar();
    }

}
