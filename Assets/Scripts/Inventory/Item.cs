using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "")]
public class Item : ScriptableObject
{
    [Header("Item Attributes")]
    public string itemName;
    public Sprite itemImage;
    public int itemHeld;

    public bool isequip;

}

