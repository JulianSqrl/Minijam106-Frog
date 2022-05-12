using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothCamera : MonoBehaviour
{
    public Transform playerRep;
    public Transform cameraHolderRep;
    public float offset;
    public float followSpeed = 50f;
    public float rotationSpeed = 20f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 desiredPosition = playerRep.position+ cameraHolderRep.forward*offset;
        Vector3 difference = desiredPosition-transform.position;

        transform.position+= difference*Time.deltaTime*followSpeed;
        //sooootnanmrnbou rotautioiujon
        transform.rotation=Quaternion.Slerp(transform.rotation,cameraHolderRep.rotation,Time.deltaTime*rotationSpeed);

        
    }
}
