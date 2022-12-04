using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthUI : MonoBehaviour
{
    public Image hpSlider;
    public Image hungerSlider;
   [SerializeField] private CharacterStates characterStates;

    void Awake()
    {
        hpSlider = transform.GetChild(0).GetChild(0).GetComponent<Image>();
        hungerSlider = transform.GetChild(1).GetChild(0).GetComponent<Image>();
        characterStates = transform.GetComponentInParent<CharacterStates>();
    }

    private void Update()
    {
        UpdateUI();
        
    }

    public void UpdateUI() 
    {
        //int length = 0; 
        //foreach(var i in GameManager.Instance.playerstatesList) 
        //{
        //    float sliderPercent = (float)GameManager.Instance.playerstatesList[length].currentHealth / GameManager.Instance.playerstatesList[length].characterData.maxHealth;
        //    healthSlider.fillAmount = sliderPercent;
        //    length++;
        //}
        float HealthsliderPercent = (float)characterStates.characterData.currentHealth / characterStates.characterData.maxHealth;
        hpSlider.fillAmount = HealthsliderPercent;
 
        float HVsliderPercent = (float)characterStates.characterData.currentHV / characterStates.characterData.maxHV;
        hungerSlider.fillAmount = HVsliderPercent;

    }

 
}
