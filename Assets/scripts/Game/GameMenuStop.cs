using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuStop : MonoBehaviour
{
    
    public void Go_to_Menu()
    {
        SceneManager.LoadScene(0);
    }
    public void GamePause()
    {
        Time.timeScale = 0;
    }
    public void StopGamePause()
    {
        Time.timeScale = 1;
    }
}
