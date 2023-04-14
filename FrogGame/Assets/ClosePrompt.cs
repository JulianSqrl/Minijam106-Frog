using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePrompt : MonoBehaviour
{
    public GameUI pauseManager;
    public KeyCode promptclose = KeyCode.X;
  bool     read = false;
  public   GameObject Prompt;
  public   GameObject[] Game_play_UI;
    void Awake()
    {
        pauseManager.SetPause(true);
        Cursor.lockState = CursorLockMode.None;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(read == false)
        {
            if (Input.GetKeyDown(promptclose))
            {

                Close();
            }
        }
   
    }
    void Close()
    {
        if (read == false)
        {
            foreach (var item in Game_play_UI)
            {
                item.SetActive(true);
            }
            read = true;
            pauseManager.CanPause = true;
            pauseManager.SetPause(false);
            Cursor.lockState = CursorLockMode.Locked;
            Prompt.SetActive(false);
        }
    }
    public void WindowClose()
    {
        Close();
    
        
    }
}
