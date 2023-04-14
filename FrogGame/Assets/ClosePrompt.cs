using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClosePrompt : MonoBehaviour
{
  public KeyCode promptclose = KeyCode.X;
  bool read = false;
  public   GameObject Prompt;
  public GameObject[] Game_play_UI;
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
                Prompt.SetActive(false);
                foreach (var item in Game_play_UI)
                {
                    item.SetActive(true);
                }

                read = true;
            }
        }
   
    }
}
