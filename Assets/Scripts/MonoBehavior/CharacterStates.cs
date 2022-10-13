using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStates : MonoBehaviour
{
    public CharacterData_SO characterData;

    #region  Read from Data_SO
    public int maxHealth
    {
        get { if (characterData != null) return characterData.maxHealth; else return 0; }
        set { characterData.maxHealth = value; }
    }
    public int currentHealth
    {
        get { if (characterData != null) return characterData.currentHealth; else return 0; }
        set { characterData.currentHealth = value; }
    }
    public int maxHV
    {
        get { if (characterData != null) return characterData.maxHV; else return 0; }
        set { characterData.maxHV = value; }
    }
    public int currentHV
    {
        get { if (characterData != null) return characterData.currentHV; else return 0; }
        set { characterData.currentHV = value; }
    }
    public int maxSP
    {
        get { if (characterData != null) return characterData.maxSP; else return 0; }
        set { characterData.maxSP = value; }
    }
    public int currentSP
    {
        get { if (characterData != null) return characterData.currentSP; else return 0; }
        set { characterData.currentSP = value; }
    }
    #endregion
}
