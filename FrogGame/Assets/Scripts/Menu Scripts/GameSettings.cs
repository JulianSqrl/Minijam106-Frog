using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameSettings : MonoBehaviour
{

    [SerializeField]
    private Slider volumeSlider;
    [SerializeField]
    Toggle MuteToggle;

    // Start is called before the first frame update
    void Start()
    {
        //Setup UI and Events
       SetupSliderUI();
       SetupSliderUI();


    }
    void SetupSliderUI()
    {
        //Slider
        volumeSlider.value = MusicManager.Instance.CurrentVolume;
        MusicManager.Instance.ChangeMasterVolume(volumeSlider.value);
        volumeSlider.onValueChanged.AddListener(val => MusicManager.Instance.ChangeMasterVolume(val));
    }
    void SetupTogleUI()
    {
        //Toggle
        MuteToggle.isOn = MusicManager.Instance.Mute;
        MuteToggle.onValueChanged.AddListener(delegate { Toggle(); });
    }
  public void Toggle()
    {
      MusicManager.Instance.ToggleSound();
  
    }
}
