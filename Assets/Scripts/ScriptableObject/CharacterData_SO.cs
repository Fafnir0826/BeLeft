using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Data", menuName = "Character Stats/Data")]
public class CharacterData_SO : ScriptableObject
{
    [Header("State Info")]
    public int maxHealth;
    public int currentHealth;
    public int  maxHV;  //最大飢餓度HungerValue
    public int currentHV;  //當前飢餓度HungerValue
    public int  maxSP;  //最大耐力值
    public int  currentSP;  //當前耐力值


}

