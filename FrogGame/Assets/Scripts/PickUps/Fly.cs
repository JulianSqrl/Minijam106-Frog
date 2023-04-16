using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
public class Fly : MonoBehaviour
{
    [SerializeField]
    public TextMeshProUGUI FlyCounterText;
    [SerializeField] AudioClip PickupSFX;
  

    // Start is called before the first frame update
    void Start()
    {
        SetNumberOfFlies(0);
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    private void OnTriggerEnter(Collider other)
    {

        if(GameManager.Instance.PlayerControler != null)
        {
            int newTotal = GetNumberOfFlies() + 1;
            SetNumberOfFlies(newTotal);
            SetTotalNumberOfFlies(newTotal);
            GameManager.Instance.CurentFlyCount = newTotal;

            MusicManager.Instance.PlaySFX(PickupSFX);
            UpdateUI();
            Destroy(this.gameObject);
        }
    }


    public int GetNumberOfFlies()
    {
        return GameManager.Instance.PlayerControler.fliesCaught;
    }
    public void SetTotalNumberOfFlies(int num)
    {
        GameManager.Instance.PlayerControler.totalFlies = num;
    }
    public void  SetNumberOfFlies(int num)
    {
        GameManager.Instance.PlayerControler.fliesCaught = num;
    }
    void UpdateUI()
    {
        FlyCounterText.text = GetNumberOfFlies().ToString() + " / " + GameManager.Instance.TotalFlyCount;
    }
}
