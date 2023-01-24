using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTracker : MonoBehaviour
{
    public GameObject item;
    // Start is called before the first frame update
    void Start()
    {
        item= GameObject.Find("/ItemsToFind/Umbrella");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
