using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogCameraController : MonoBehaviour
{

    public float mouseSensitivity = 1000f;

    public Transform playerTransform;

    float xRotation = 0f;
    float yRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime*mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime*mouseSensitivity;


        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation,-90f,90f);

        yRotation += mouseX;


        playerTransform.transform.localRotation = Quaternion.Euler(xRotation,yRotation,0f);
        //playerTransform.Rotate(playerTransform.up*mouseX);
        //playerTransform.Rotate(Vector3.up*mouseX);



        
    }
}
