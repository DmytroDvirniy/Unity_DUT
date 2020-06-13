using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Pause_menu : MonoBehaviour
{
private static bool GameIsPaused = false;
public GameObject PauseMenuUi; 
    void Update()
    {
   if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused) {
                Resume ();
            } else 
            {
                Pause ();
            }
        }
     
    }
   public void Resume (){
        PauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
   }
    void Pause () {
        PauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void PB (){
        Pause ();
    }
    public void Set () {
        Application.Quit();
    }
    public void Ex () {
        SceneManager.LoadScene("Menu");
    }
}
