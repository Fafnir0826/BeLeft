using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Durability", menuName = "Objects/Durability")]
public class Durability_SO : ScriptableObject 
{
    [Header("Durability Info")]

    public int maxDurability;
    public int currentDurability;
}
