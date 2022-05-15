using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fly : MonoBehaviour
{
    //this is only set on first instance
    static int numberOfFlies = 0;

    public int GetNumberOfFlies()
    {
        return numberOfFlies;
    }


    // Start is called before the first frame update
    void Start()
    {
        numberOfFlies+=1;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        FrogController player;
        player = other.gameObject.GetComponentInParent<FrogController>();
        if(player != null)
        {
            player.fliesCaught += 1;
            player.totalFlies = numberOfFlies;
            Destroy(this.gameObject);
        }
    }



}
