using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePrompt : MonoBehaviour
{
    public KeyCode PauseKey = KeyCode.X;
  public   GameObject Prompt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(PauseKey))
        {
            Prompt.SetActive(false);
        }
    }
}
