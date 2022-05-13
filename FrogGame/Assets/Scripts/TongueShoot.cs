using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueShoot : MonoBehaviour
{

    private Transform cameraReference;



    void Awake()
    {
    }


    void Update()
    {
        //this defines when the grapple is shot
        if(Input.GetMouseButtonDown(0))
        {
            StartGrapple();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            StopGrapple();
        }

    }

    void StartGrapple()
    {

    }

    void StopGrapple()
    {

    }




}
