using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public KeyCode PauseKey = KeyCode.Escape;
    public bool isPaused = false;
     public GameObject PauseMenu;
   // public GameObject PLayerUI;

    public bool CanPause = false;
    public GameObject PlayerUIFlyCounter;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        PauseInput();
    }

    void PauseInput()
    {
        if (Input.GetKeyDown(PauseKey) && CanPause == true)
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void setCanPause(bool pause)
    {
        if (pause)
        {

            CanPause = true;

        }
        else
        {

            CanPause = false;
        }
    }
    public void SetPause(bool pause)
    {

        if (pause)
        {
            Time.timeScale = 0;
            isPaused = true;

        }
        else
        {
            Time.timeScale = 1;
            isPaused = false;
        }

    }
    public void Pause()
    {

        Time.timeScale =  0;
        isPaused = true;
        Cursor.lockState = CursorLockMode.None;
        PauseMenu.SetActive(true);
        //  PLayerUI.SetActive(false);
        PlayerUIFlyCounter.SetActive(false);
    }
    public  void Resume()
    {
        Time.timeScale = 1;
        Cursor.lockState = CursorLockMode.Locked;
        PauseMenu.SetActive(false);
        //  PLayerUI.SetActive(true);
        PlayerUIFlyCounter.SetActive(true);
        isPaused = false;
    }
}
