using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Test/CraftingRecipe")]
public class CraftingRecipe_SO : ScriptableObject
{
    public Sprite sprite;
    public List<Item> inputItemList;
    public Item outputItem;

}
