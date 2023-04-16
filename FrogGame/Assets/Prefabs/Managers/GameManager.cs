using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    //
    public int SceneIndex = 0;
                           
    public bool isPaused     = false;
    public bool CanPause     = false;


    //Game Specfic
    public FrogController PlayerControler;

    public int  CurentFlyCount  = 0;
    public int  TotalFlyCount   = 0;



public  LevelData Level;

    //
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            
            DontDestroyOnLoad(gameObject);

        }
        else
        {
            Destroy(gameObject);
        }
    }
    void start()
    {
       // MusicManager.PlaySceneTheme(0);
    }
    //DONT DESTROY DISABLES AWAKE AND START
    void OnLevelWasLoaded()
    {

        PlaySceneSoundTrack();
        if (SceneIndex == 1)
        {
            TotalFlyCount = Level.totalFlies;

        }
    }
    void PlaySceneSoundTrack()
    {
        SceneIndex = SceneManager.GetActiveScene().buildIndex;
        Debug.Log("Scene Index : " + SceneIndex);
        PlaySceneTheme(SceneIndex);



    }
    // Update is called once per frame
    void Update()
    {
     
    }
    public void PlaySceneTheme(int num)
    {

        SceneIndex = num;
        MusicManager.Instance.SoundSource.Stop();
        MusicManager.Instance.PlayLevelMusic();
    }

    public void SetCanPause(bool pause)
    {
        if (pause)
        {

           CanPause = true;

        }
        else
        {

          CanPause = false;
        }
    }
    public void SetPause(bool pause)
    {

        if (pause)
        {
          
           isPaused = true;

        }
        else
        {
          
           isPaused = false;
        }

    }
}
