using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//so this is a rigid body that is mostly independant of the frog that fired it but does have a reference to its transform
[RequireComponent(typeof(Rigidbody))]
public class Tongue : MonoBehaviour
{
/*
    Rigidbody rigidbody;
    Vector3 pointOfFiring = new Vector3(0f,0f,0f);
    //this is when all the elastic energy has been turned to velocity
    float maxTongueSpeed;



    //pick and initial direction and velocity that is determined by that which fired it
    public float initialSpeed;
    public Vector3 initialDirection;
    public Tongue(float initSpeed,Vector3 initDir)
    {
        initialSpeed = initSpeed;
        initialDirection = initDir;
    }


    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        //pick and initial direction and velocity that is determined by that which fired it
        rigidbody.velocity = initialDirection*initialSpeed;

        
    }



    // Update is called once per frame
    void Update()
    {
        float pointOfRebound = 20f;
        Vector3 tongueDistanceVector = (-pointOfFiring+transform.position);


        if(tongueDistanceVector.magnitude>pointOfRebound && (rigidbody.velocity.normalized+tongueDistanceVector).magnitude > tongueDistanceVector.magnitude)
        {
            //do the pphysics stuff here
            //rigidbody.AddForce(-new Vector3(rigidbody.mass*rigidbody.velocity.x,0f,rigidbody.mass*rigidbody.velocity.z));
            rigidbody.AddForce(-rigidbody.velocity*rigidbody.mass);
        }
        else{
            //update whenever elastic effects arent being done
            maxTongueSpeed = rigidbody.velocity.magnitude;
        }

        
    }
*/
}
