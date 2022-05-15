using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUI : MonoBehaviour
{
    public KeyCode PauseKey = KeyCode.Escape;
    public bool isPaused = false;
     public GameObject PauseMenu;
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
        if (Input.GetKeyDown(PauseKey))
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
    public void Pause()
    {

        Time.timeScale =  0;
        isPaused = true;
        PauseMenu.SetActive(true);
    }
    public  void Resume()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
        isPaused = false;
    }
}
