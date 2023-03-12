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
        PlayerPrefs.SetInt("language", GameManeger.language);
    }

    public void changeRussian()
    {
        GameManeger.language = 0;
    }
    public void changeEnglish()
    {
        GameManeger.language = 1;
    }
}
