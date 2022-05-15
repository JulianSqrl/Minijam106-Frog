using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachItem : MonoBehaviour
{
    string Name;
    public bool Found;
   
    public void Reveal()
    {
        gameObject.SetActive(true);
    }
}
