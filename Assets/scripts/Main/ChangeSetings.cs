using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSetings : MonoBehaviour
{
    public GameManeger GameManeger;
    void Start()
    {
        GameManeger = GameObject.FindGameObjectWithTag("GameManeger").GetComponent<GameManeger>();
    }



    public void SaveGame()
    {
        GameManeger.SaveGame();
    }

    public void changeRussian()
    {
        GameManeger.changeRussian();
    }
    public void changeEnglish()
    {
        GameManeger.changeEnglish();
    }
}
