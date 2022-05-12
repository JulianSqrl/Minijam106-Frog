using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueShoot : MonoBehaviour
{
    private LineRenderer lr;
    private Vector3 grapplePoint;
    public LayerMask whatIsGrappleable;

    void Awake()
    {
        lr =GetComponent<LineRenderer>();
    }

    void Update()
    {
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
        RaycastHit hit;

    }




}
