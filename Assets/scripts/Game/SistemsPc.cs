using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemsPc : MonoBehaviour
{
    public TaskBarGame TaskBarGame;

    public int TechnologyMin, TechnologyMax;
    public Text TechnologyMinText, TechnologyMaxText;
    public int DesignMin, DesignMax;
    public Text DesignMinText, DesignMaxText;
    public int GameplayMin, GameplayMax;
    public Text GameplayMinText, GameplayMaxText;
    public int Ticks;
    void Start()
    {
        UpdateGameSistem();
        StartCoroutine(Tick());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Tick()
    {
        while (true)
        {
            TaskBarGame.Technology += Random.Range(TechnologyMin, TechnologyMax);
            TaskBarGame.Design += Random.Range(DesignMin, DesignMax);
            TaskBarGame.Gameplay += Random.Range(GameplayMin, GameplayMax);
            TaskBarGame.UpdateTaks();

            yield return new WaitForSeconds(1.2f);
            TaskBarGame.StopUpdateTaks();
            yield return new WaitForSeconds(5);
        }


    }
    public void UpdateGameSistem()
    {
        TechnologyMinText.text = TechnologyMin + " -";
        TechnologyMaxText.text = TechnologyMax.ToString();
        DesignMinText.text = DesignMin + " -";
        DesignMaxText.text = DesignMax.ToString();
        GameplayMinText.text = GameplayMin + " -";
        GameplayMaxText.text = GameplayMax.ToString();
    }
}
