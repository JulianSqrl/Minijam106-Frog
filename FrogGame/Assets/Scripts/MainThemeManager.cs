using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MainThemeManager : MonoBehaviour
{
    public AudioSource normalTheme;
    public AudioSource flyingTheme;

    public FrogController playerRef;

    public float timer = 0f;

    float transitionStage = 0.0f;
    bool justChanged = true;

    bool lastReverse = false;
    float audioBuffer = 0.0f;

    


    void Start()
    {
        normalTheme.Play();
        flyingTheme.Play();
        normalTheme.loop = false;
        flyingTheme.loop = false;

        normalTheme.volume = 1.0f;
        flyingTheme.volume = 0.0f;
    }


    void Update()
    {
        timer += Time.deltaTime;
        if(timer >= 290f)
        {
            normalTheme.Play();
            flyingTheme.Play();
        }

        

        if(playerRef.IsNotColliding)
        {
            Transition(flyingTheme,normalTheme,true);
        }
        else
        {
            Transition(flyingTheme,normalTheme,false);
        }
    }

    //first input will become 1 second will become 0
    void Transition(AudioSource a1,AudioSource a2,bool reverse)
    {
        if(lastReverse != reverse)
        {
            lastReverse = reverse;
            audioBuffer = 0.0f;
        }
        audioBuffer += Time.deltaTime;
        
        if(audioBuffer < 0.6f)
        {
            return;
        }


        if(reverse)
        {
            transitionStage -= Time.deltaTime;
        }
        else
        {
            transitionStage += Time.deltaTime;
        }

        transitionStage = Mathf.Clamp(transitionStage,0.0f,1.0f);

        a1.volume = 1f-transitionStage;
        a2.volume = transitionStage;

        /*
        if(a1 != lastA1)
        {
            lastA1 = a1;
            audioBuffer = 0.0f;
            transitionStage = 0.0f;
            return;
        }
        audioBuffer += Time.deltaTime;



        if(audioBuffer <0.5f)
        {
            return;
        }
        


        


        transitionStage += Time.deltaTime * 0.3f;
        transitionStage = Mathf.Clamp(transitionStage,0.0f,1.0f);




        a1.volume = transitionStage;
        a2.volume = 1- transitionStage;
        */
    }


    
    
}
