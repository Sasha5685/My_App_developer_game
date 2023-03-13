using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class language_game : MonoBehaviour
{
    public GameManeger GameManeger;

    public GameObject TextRus;
    public GameObject TextEng;
    void Start()
    {
        GameManeger = GameObject.FindGameObjectWithTag("GameManeger").GetComponent<GameManeger>();


        if (GameManeger.language == 0)
        {
            TextRus.gameObject.SetActive(true);
            TextEng.gameObject.SetActive(false);
        }
        if (GameManeger.language == 1)
        {
            TextRus.gameObject.SetActive(false);
            TextEng.gameObject.SetActive(true);
        }
    }

}
