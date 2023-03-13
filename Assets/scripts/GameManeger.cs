using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public int language; //������� - 0, ���������� - 1
    public int Graphics; //������ - 1, ������� - 2, ������ - 3
    public int NewGame;  //��� ���������� - 0, ���� ���������� - 1
    void Start()
    {
        if (PlayerPrefs.HasKey("language")) // �������� �� ����
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
