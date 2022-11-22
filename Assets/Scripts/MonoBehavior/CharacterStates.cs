using System;
using UnityEngine;


public class CharacterStates : MonoBehaviour
{
    //public event Action<int, int> UpdateHealthBarOnAttack;
    public CharacterData_SO templateData;
    public CharacterData_SO characterData;

    public AttackData_SO attackData;

    [HideInInspector]
    public bool isCritical;

    void Awake()
    {
        if (templateData != null)
            characterData = Instantiate(templateData);
        templateData.currentHealth = characterData.maxHealth;
    }

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

    #region  Character Combat
    public void TakeDamage(CharacterStates attacker, CharacterStates defender)
    {
        int damage = Mathf.Max(attacker.CurrentDamage(), 0);
        currentHealth = Mathf.Max(currentHealth - damage, 0);

        if (attacker.isCritical)
        {
            defender.GetComponent<Animator>().SetTrigger("Hit");
        }

        //TODO:Update UI
       // UpdateHealthBarOnAttack?.Invoke(currentHealth, maxHealth);

    }

    public void TakeDamage(int damage, CharacterStates defender)
    {
        int currentDamage = damage;
        currentHealth = Mathf.Max(currentHealth - currentDamage, 0);
        //UpdateHealthBarOnAttack?.Invoke(currentHealth, maxHealth);

    }

    private int CurrentDamage()
    {
        float coreDamage = UnityEngine.Random.Range(attackData.minDamage, attackData.maxDamage);

        if (isCritical)
        {
            coreDamage *= attackData.criticalMultiplier;
            // Debug.Log("critical"+coreDamage);
        }
        return (int)coreDamage;
    }
    #endregion

}
