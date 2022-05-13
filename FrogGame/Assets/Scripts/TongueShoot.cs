using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TongueShoot : MonoBehaviour
{

    bool grappling = false;

    public LineRenderer lineRenderer;

    public Transform cameraReference;
    public Transform playerReference;
    public Transform frogModelReference;


    public LayerMask TongueAtachable;


    Vector3 swingPosition;


    SpringJoint joint;



    void Awake()
    {
    }


    void LateUpdate()
    {
        DrawTongue();
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








    

    void LaunchTongue()
    {
        //launch a physics object toward the direction of the camera and link the swing function to it

    }

    void RetractTongue()
    {
        //launches the tongue back toward the player and when colliding with the player deletes it

    }



    void DrawTongue()
    {
        if(grappling)
        {
            lineRenderer.SetPosition(0,frogModelReference.position);
            lineRenderer.SetPosition(1,swingPosition);
        }
    }



    void StartGrapple()
    {
        //print(cameraReference.forward);
        RaycastHit hit;
        //print(cameraReference.position);
        if(Physics.Raycast(origin:cameraReference.position,direction:cameraReference.forward,out hit,300f,TongueAtachable))
        {
            SpringJoint joint;
            //this is so the stop grapple has no errors
            if(playerReference.gameObject.TryGetComponent<SpringJoint>(out joint) == false)
            {
                joint=playerReference.gameObject.AddComponent<SpringJoint>();
            }


            swingPosition = hit.point;
            joint.autoConfigureConnectedAnchor = false;
            joint.connectedAnchor = swingPosition;

            float tongueDistance = Vector3.Distance(playerReference.position,swingPosition);

            joint.maxDistance = tongueDistance*0.8f;
            joint.minDistance = tongueDistance *0.25f;

            joint.spring = 4.5f;
            joint.damper = 7f;
            joint.massScale = 4.5f;
            
            //so the line renderer can work properlly
            lineRenderer.positionCount = 2;
            grappling = true;
            
        }
    }

    void StopGrapple()
    {
        //so the tongue derenders
        lineRenderer.positionCount = 0;


        if(playerReference.gameObject.TryGetComponent<SpringJoint>(out joint))
        {
            joint.breakForce = 0f;
            joint = null;
        }

        grappling = false;
    }




}
