using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogController : MonoBehaviour
{
    //ref to rigidbody
    public Rigidbody rigidbody;

    //this is the object that holds the driection that the player jumpps in(camera)
    public Transform jumpDirection;

    //this is so that the car knows when to drive
    private int collisionCount = 0;
 
    public bool IsNotColliding
    {
        get { return collisionCount == 0; }
    }



    void Start()
    {
        rigidbody.freezeRotation = true;
        
    }

    void Update()
    {

        FrogMove();
    }

    

    //the little forward hops
    void FrogMove()
    {
        //transform.rotation=Quaternion.Slerp(transform.rotation,Quaternion.Euler(0f,0f,1f),Time.deltaTime);
        //rigidbody.angularVelocity = Quaternion.ToEulerAngles(Quaternion.Slerp(transform.rotation,Quaternion.Euler(0f,0f,1f),Time.deltaTime));
        float forward = Input.GetAxis("Vertical");
        if(forward != 0f &&  !IsNotColliding)
        {
            rigidbody.AddForce(-new Vector3(rigidbody.velocity.x,0f,rigidbody.velocity.z)*rigidbody.mass);

            //get the forward vector and then apply upward force if colliding
            Vector3 jumpVector = new Vector3(0f,0.2f,0.8f).normalized;
            //this rotates this to fit the cameras direction
            jumpVector = new Quaternion(0f,jumpDirection.rotation.y,0f,jumpDirection.rotation.w)*jumpVector;

            //vector = Quaternion.AngleAxis(-45, Vector3.up) * vector;
            rigidbody.AddForce(jumpVector*10f);
            
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
