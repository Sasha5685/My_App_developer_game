using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
    //Debug.Log("Ошибка - 1");
    public void ExitGame()
    {
        Application.Quit();
    }
    public void Resume_Game()
    {
        SceneManager.LoadScene(1);
    }
}
