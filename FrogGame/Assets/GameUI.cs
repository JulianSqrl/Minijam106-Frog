using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public KeyCode PauseKey = KeyCode.Escape;
    public bool CanPause = false;
    public bool isPaused = false;
<<<<<<< Updated upstream
     public GameObject PauseMenu;
=======
    public GameObject PauseMenu;
    public GameObject PlayerUI;
    public GameObject PlayerUIFlyCounter;
>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        PauseInput();
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
<<<<<<< Updated upstream
=======
      //  PlayerUI.SetActive(false);
        PlayerUIFlyCounter.SetActive(false);
>>>>>>> Stashed changes
    }
    public  void Resume()
    {
        Time.timeScale = 1;

        PauseMenu.SetActive(false);
<<<<<<< Updated upstream
=======
       // PlayerUI.SetActive(true);
        PlayerUIFlyCounter.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
>>>>>>> Stashed changes
        isPaused = false;
    }
}
