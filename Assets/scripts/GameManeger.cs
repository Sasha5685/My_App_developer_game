using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public int language; //Русский - 0, Английский - 1
    public int Graphics; //Низкая - 1, средняя - 2, ультра - 3
    public int NewGame;  //Нет сохранений - 0, есть сохранение - 1
    void Start()
    {
        if (PlayerPrefs.HasKey("language")) // Проверка на язык
        {
            language = PlayerPrefs.GetInt("language");
        }
    }

    public void SaveGame()
    {
        PlayerPrefs.SetInt("language", language);
    }

    public void changeRussian()
    {
        language = 0; PlayerPrefs.SetInt("language", language);
    }
    public void changeEnglish()
    {
        language = 1; PlayerPrefs.SetInt("language", language);
    }
}
