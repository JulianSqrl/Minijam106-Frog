using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoundObjects : MonoBehaviour
{

    public GameObject[] BeachProps;
    ItemTracker FoudItems;
    // Start is called before the first frame update
    void Start()
    {
       // BeachPropsContainer = GameObject.FindGameObjectsWithTag("BeachProp");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckIfFound()
    {
        for (int i = 0; i < FoudItems.BeachItems.Count; i++)
        {
           
             if (FoudItems.BeachItems[i].Found == true )
             {
                BeachProps[i].SetActive(true);
             }
            else
            {
                BeachProps[i].SetActive(false);
            }
         
           
        }
    }
}
