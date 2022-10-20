using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory/Bag")]
public class Inventory : ScriptableObject
{
    public List<Item> itemLists = new List<Item>();
}
