using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class FrogController : MonoBehaviour
{
    //for UI purposes
    public int fliesCaught;

    public AudioSource tongueSound;

    //ref to rigidbody
    public Rigidbody rigidbody;

    //this is the object that holds the driection that the player jumpps in(camera)
    public Transform jumpDirection;


    private Vector3 lastDirection;

    //this is so that the car knows when to drive
    private int collisionCount = 0;


    bool ShortenTongue = false;
    bool jumpBeingPrepared = false;
    
 
    public bool IsNotColliding
    {
        get { return collisionCount == 0; }
    }


    //this should reset to zero on release
    public float jumpPower = 0f;


    void Start()
    {
        rigidbody.freezeRotation = true;
        
    }

    void Update()
    {
        FrogJump();
        FrogMove();
        FrogAirMove();

        if(ShortenTongue && !IsNotColliding)
        {
            //this is so that grapple shorten works
            rigidbody.AddForce(new Vector3(0f,0.1f,0f));
            
        }

        if(Input.GetMouseButtonDown(1) )
        {
            ShortenTongue = true;

        }
        if(Input.GetMouseButtonUp(1))
        {
            ShortenTongue = false;

        }

    }


    void FrogAirMove()
    {
        if(IsNotColliding)
        {

        }
    }

    
    void FrogJump()
    {
        if(Input.GetAxis("Jump")!= 0f)
        {
            jumpBeingPrepared = true;
            if(jumpPower + Time.deltaTime >1f)
            {
                jumpPower = 1f+(fliesCaught);
            }
            else
            {
                jumpPower += Time.deltaTime;
            }
        }
        else
        {
            if(!IsNotColliding && jumpBeingPrepared == true)
            {
                float forward = Input.GetAxis("Vertical");

                rigidbody.AddForce(new Vector3(0f,1f,0f)*jumpPower*600f);
                rigidbody.AddForce(new Quaternion(0f,jumpDirection.rotation.y,0f,jumpDirection.rotation.w)*rigidbody.transform.forward*forward*200f);
                jumpBeingPrepared = false;
                jumpPower = 0f;
            }
        }

    }

    //the little forward hops
    void FrogMove()
    {
        //transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.Euler(0f,0f,1f),Time.deltaTime);
        //rigidbody.angularVelocity = Quaternion.ToEulerAngles(Quaternion.Slerp(transform.rotation,Quaternion.Euler(0f,0f,1f),Time.deltaTime));
        
        float forward = Input.GetAxis("Vertical");

        if(forward != 0f &&  !IsNotColliding && jumpPower ==0f)
        {
            rigidbody.AddForce(-new Vector3(rigidbody.velocity.x,0f,rigidbody.velocity.z)*rigidbody.mass);

            //get the forward vector and then apply upward force if colliding
            Vector3 jumpVector = new Vector3(0f,0.2f,0.8f).normalized;
            if(forward > 0)
            {
                jumpVector = new Vector3(0f,0.3f,0.8f).normalized;

            }
            else if(forward < 0)
            {
                jumpVector = new Vector3(0f,0.3f,-0.8f).normalized;
            }
            
            //this rotates this to fit the cameras direction 
            jumpVector = new Quaternion(0f,jumpDirection.rotation.y,0f,jumpDirection.rotation.w)*jumpVector;


            
            lastDirection = jumpVector;
            //vector = Quaternion.AngleAxis(-45, Vector3.up) * vector;
            rigidbody.AddForce(jumpVector*10f);
            
        }

        if(forward == 0 && !IsNotColliding)
        {
            rigidbody.AddForce(-new Vector3(rigidbody.velocity.x,0f,rigidbody.velocity.z)*rigidbody.mass);
        }
    }




    //keeps track of whether colliding
     void OnCollisionEnter(Collision col)
     {
         //maybe add a fun little collision noise 
         collisionCount++;
     }
 
     void OnCollisionExit(Collision col)
     {
         collisionCount--;
     }

}
