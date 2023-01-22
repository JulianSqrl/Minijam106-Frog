using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour
{
    float count = 300f;

    void Update()
    {
        count -= Time.deltaTime;
        if(count <0)
        {
            SceneManager.LoadScene(4);

        }
    }
}
