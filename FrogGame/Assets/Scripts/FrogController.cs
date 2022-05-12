using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    void Start()
    {
        
    }

    void Update()
    {
        float forward = Input.GetAxis("Vertical");
        if(forward != 0f)
        {
            print("e");
        }
        
    }
}
