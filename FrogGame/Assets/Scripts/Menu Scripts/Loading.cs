using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
public class Loading : MonoBehaviour
{

    public GameObject LoadingScreen;

    public Animator anim;
    public float TranstionTime = 1.5f;
    public Slider LoadingBar;
    public TextMeshProUGUI percentagetxt;

    public void Load(int SceneNum)
    {
        if (LoadingScreen.activeSelf == false)
        {
            LoadingScreen.SetActive(true);
           
        }
        StartCoroutine(LoadScene(SceneNum));
    
    }
   
    IEnumerator LoadScene(int SceneNum)
    {
        anim.SetTrigger("Start");
        yield return new WaitForSecondsRealtime(TranstionTime);
        AsyncOperation AsyncLoading = SceneManager.LoadSceneAsync(SceneNum);
      
     
    }

    //Loads Main Menu
    public void LoadMainMenu()
    {
        GameManager.Instance.PlaySceneTheme(0);
        SceneManager.LoadScene(0);
    }
    //Loads a scene by taking in its index number
    public void LoadALevel(int num)
    {
        GameManager.Instance.PlaySceneTheme(num);
        SceneManager.LoadScene(num);

    }

}
