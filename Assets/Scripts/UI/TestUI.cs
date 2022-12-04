using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestUI : MonoBehaviour
{
    public Image hpSlider;
    public Image hungerSlider;
   

    void Awake()
    {
        hpSlider = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        hungerSlider = transform.GetChild(1).GetChild(0).GetComponent<Image>();
        
    }

    private void Update()
    {
        UpdateUI();
        
    }

    public void UpdateUI() 
    {
       
        
        hpSlider.fillAmount = 100.0f / 2.0f* Time.deltaTime;
       

        hpSlider.fillAmount = 100.0f / 2.0f * Time.deltaTime; ;

    }

 
}
