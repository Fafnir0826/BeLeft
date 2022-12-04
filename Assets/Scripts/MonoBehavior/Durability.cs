using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Durability : MonoBehaviour
{
    public Durability_SO durability;

    public int maxDurability
    {
        get { if (durability != null) return durability.maxDurability; else return 0; }
        set { durability.maxDurability = value; }
    }
    public int currentDurability
    {
        get { if (durability != null) return durability.currentDurability; else return 0; }
        set { durability.currentDurability = value; }
    }
}
