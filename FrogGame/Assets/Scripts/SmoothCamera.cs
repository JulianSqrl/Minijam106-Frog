using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform playerRep;
    public Transform cameraHolderRep;
    public float forwardOffset;
    public float upwardOffset;
    public float followSpeed = 50f;
    public float rotationSpeed = 20f;

    public Vector3 cameraVelocity = Vector3.zero;




    //this is so that the camera knows when colliding
    private int collisionCount = 0;
    public bool IsNotColliding
    {
        get { return collisionCount == 0; }
    }




    Quaternion newRotation;
    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Vector3 desiredPosition = playerRep.position+ cameraHolderRep.forward*forwardOffset +cameraHolderRep.up*upwardOffset;
        transform.position = desiredPosition;
    }

    void Update()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = playerRep.position+ cameraHolderRep.forward*forwardOffset +cameraHolderRep.up*upwardOffset;
        Vector3 difference = desiredPosition-transform.position;

        /*
        print((difference.normalized*Time.deltaTime*followSpeed).magnitude);
        if((difference.normalized*Time.deltaTime*followSpeed).magnitude >(difference*Time.deltaTime).magnitude)
        {
            transform.position = desiredPosition;
        }
        else
        {
            transform.position+= difference.normalized*Time.deltaTime*followSpeed;
        }
        */
        float trueFollowSpeed = followSpeed;


            //transform.position+= difference.normalized*Time.deltaTime*trueFollowSpeed;
            //transform.TransformDirection(difference.normalized*Time.deltaTime*trueFollowSpeed);
        transform.position = Vector3.SmoothDamp(transform.position,desiredPosition,ref cameraVelocity,0.1f);



        //sooootnanmrnbou rotautioiujon
        transform.rotation=Quaternion.Slerp(transform.rotation,cameraHolderRep.rotation,Time.deltaTime*rotationSpeed);

        
    }



}
