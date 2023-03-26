using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingGameSistem : MonoBehaviour
{
    public Animator animSetCreateGame;
    public GameObject BackGroundSetings;
    public int IsSetCreateGame;


    public void ClouseCreateGame()
    {
        animSetCreateGame.SetBool("IsCreating", false);
        IsSetCreateGame = 1;

    }
    public void CreateGame()
    {
        BackGroundSetings.SetActive(true);
        IsSetCreateGame = 0;
        animSetCreateGame.SetBool("IsCreating", true);

    }

}
