using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelController : MonoBehaviour
{
    public Transform CameraReference;
    public Transform ModelReference;

    void Update()
    {
        Vector3 eulerCam = CameraReference.rotation.eulerAngles;
 
        ModelReference.rotation = Quaternion.Euler(-90f,eulerCam.y,0f);
    }

}
