using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager Instance;

    [Header("Controls")]

    [SerializeField]
    public float CurrentVolume = 0.5f;
    [SerializeField]
    public bool Mute = false;

    [Header("Audio Clips")]
 
    [SerializeField] AudioClip MainMenuTheme;
    [SerializeField] AudioClip EndTheme;
    [SerializeField] AudioClip LoseTheme;

    [Header("Audio Sources")]

    [SerializeField] 
    public AudioSource SoundSource;
    [SerializeField] 
    private AudioSource SFXSource;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Instance.ChangeMasterVolume(CurrentVolume);
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {

       
    }
    //Controls
    public void PlaySound(AudioClip clip)
    {
      // SoundSource.Stop();
       SoundSource.clip = clip;
       SoundSource.Play();
    }
    public void PlaySFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
    public void ChangeMasterVolume(float volume)
    {
        CurrentVolume = volume;
        AudioListener.volume = CurrentVolume;
    }

    public void ToggleSound()
    {
        if(!Mute)
        {
            Mute = true;
            SoundSource.mute = Mute;

        }
        else
        {
            Mute = false;
            SoundSource.mute = Mute;
        }
       
    }

    public void PlayLevelMusic()
    {
        switch (GameManager.Instance.SceneIndex)
        {
            case 0:
                //Main Menu
         
                PlaySound(MainMenuTheme);
                break;
            case 2:
                // Level 1
                PlaySound(EndTheme);
                break;

            case 3:
                // Level 1
                PlaySound(LoseTheme);
                break;
               
        }
        Debug.Log(" Music For Scene :" + GameManager.Instance.SceneIndex);
    }
}
