using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//so we can get the right things
using UnityEngine.UI;

public class PlayerUIController : MonoBehaviour
{
    public Canvas playerUI;

    public GameObject playerRef;
    private FrogController playerController;




    public Slider jumpSlider;
    private int fliesCaught = 1;
    private int maxFlies = 10;

    void Start()
    {
        playerController = playerRef.GetComponent<FrogController>();
    }



    void Update()
    {
        
        jumpSlider.value = playerController.jumpPower;
        /*
        if(playerController.fliesCaught!= fliesCaught)
        {
            print("e");
            fliesCaught = playerController.fliesCaught;
            jumpSlider.value = (10+fliesCaught)/10+maxFlies;
        }
        */
        

    }
}
