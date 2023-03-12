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
        PlayerPrefs.GetInt("language");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
