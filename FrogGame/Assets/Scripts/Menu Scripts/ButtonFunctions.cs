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
    public void LoadMainMenu()
    {

        SceneManager.LoadScene(0);
    }
    public void LoadLevelOne()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadEnd()
    {
        SceneManager.LoadScene(2);
    }
    public void StopMusic()
    {
    
        MusicManager.Instance.SoundSource.Stop();
    }
    public void PlaySoundTrack(int num)
    {
        GameManager.Instance.PlaySceneTheme(num);
    }
}
