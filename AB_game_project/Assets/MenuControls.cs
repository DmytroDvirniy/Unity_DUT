using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
   public void PlayPressed()
    {
        SceneManager.LoadScene("Game");
    }

    public void ExitPressed()
    {
        Application.Quit();
    }
    public void LevelPressed()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Level1Pressed()
    {
        SceneManager.LoadScene("Game");
    }

     public void Level2Pressed()
    {
        SceneManager.LoadScene("Game 2");
    }

     public void Level3Pressed()
    {
        SceneManager.LoadScene("Game 3");
    }

     public void Level4Pressed()
    {
        SceneManager.LoadScene("Game 4");
    }

     public void Level5Pressed()
    {
        SceneManager.LoadScene("Game 5");
    }

    
}
