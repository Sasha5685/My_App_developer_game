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
        PlayerPrefs.GetInt("language");
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
