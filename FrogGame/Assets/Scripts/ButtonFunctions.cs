using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{

    //Can be used on UI Buttons

   
    public void Pause()
    {
        Time.timeScale = - 1;
    }
    public static void Resume()
    {
        Time.timeScale = 1;
    }
    public void Restart()
    {
        //reset Player code//or reload level
        //Respawn();
        Resume();
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Respawn()
    {

    }
   
}
