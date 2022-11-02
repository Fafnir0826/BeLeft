using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Item")]
public class Item : ScriptableObject
{
    public enum ItemType 
    {
        None,
        Wood,
        Sword,
        Stone,
        barrel
    }
    [Header("Item Attributes")]
    public string itemName;
    public ItemType itemType;
    public Sprite itemImage;
    public int itemHeld;

    public GameObject dropObjects;


    public bool isequip;

    

}


