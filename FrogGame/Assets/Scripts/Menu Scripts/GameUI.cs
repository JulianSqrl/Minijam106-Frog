using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public KeyCode PauseKey = KeyCode.Escape;

    public GameObject PauseMenu;
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
        if (Input.GetKeyDown(PauseKey) && GameManager.Instance.CanPause == true)
        {
            if (GameManager.Instance.isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    public void SetCanPause(bool pause)
    {
        GameManager.Instance.SetCanPause(pause);
  
    }

    public void Pause()
    {
        GameManager.Instance.SetPause(true);
        Time.timeScale =  0;
      
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
        GameManager.Instance.SetPause(false);
    }

}
