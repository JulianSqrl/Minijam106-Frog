using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePrompt : MonoBehaviour
{

    public KeyCode promptClose = KeyCode.X;

  public   GameObject Prompt;
  public   GameObject[] Game_play_UI;
    // Start is called before the first frame update
    void Awake()
    {
       
    }
    void Start()
    {
        Time.timeScale = 0;
        GameManager.Instance.SetPause(true);
        GameManager.Instance.CanPause = false;
        Cursor.lockState              = CursorLockMode.None;

    }

    // Update is called once per frame
    void Update()
    {
  
            if (Input.GetKeyDown(promptClose))
            {
                Close();
            }
    
   
    }

    void Close()
    {
  
            foreach (var item in Game_play_UI)
            {
                item.SetActive(true);
            }

            Cursor.lockState = CursorLockMode.Locked;

            GameManager.Instance.SetCanPause(true);
            GameManager.Instance.SetPause(false);

            Time.timeScale = 1;

            Destroy(this.gameObject);

        
    }
    public void WindowClose()
    {
        Close();


    }
}
