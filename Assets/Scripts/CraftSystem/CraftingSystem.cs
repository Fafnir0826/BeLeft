using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingSystem
{
    public const int GRID_SIZE = 3;

    private Item[,] itemArray;

    //private Dictionary<Item.ItemType, Item.ItemType[,]> recipeDictionary;

    private List<Recipe_SO> recipeSOList;

    private Item outputItem;

    public CraftingSystem(List<Recipe_SO> recipeSOList)
    {
        this.recipeSOList = recipeSOList;
        itemArray = new Item[GRID_SIZE, GRID_SIZE];

       /* recipeDictionary = new Dictionary<Item.ItemType, Item.ItemType[,]>();

        Item.ItemType[,] recipe = new Item.ItemType[GRID_SIZE, GRID_SIZE];

        recipe = new Item.ItemType[GRID_SIZE, GRID_SIZE];
        recipe[0, 2] = Item.ItemType.None; recipe[1, 2] = Item.ItemType.None; recipe[2, 2] = Item.ItemType.None;
        recipe[0, 1] = Item.ItemType.None; recipe[1, 1] = Item.ItemType.Wood; recipe[2, 1] = Item.ItemType.None;
        recipe[0, 0] = Item.ItemType.None; recipe[1, 0] = Item.ItemType.Wood; recipe[2, 0] = Item.ItemType.None;

        recipeDictionary[Item.ItemType.barrel] = recipe;*/
    }

    private bool IsEmpty(int x, int y) 
    {
        return itemArray[x, y] = null;
    }

    public Item GetItem(int x, int y) 
    {
        return itemArray[x, y];
    }

    private void SetItem(Item item, int x, int y)
    {
        itemArray[x, y] = item;
    }

    private void IncreaseItmeAmount(int x, int y) 
    {
        GetItem(x, y).itemHeld++;
    }
    private void DecreaseItmeAmount(int x, int y)
    {
        GetItem(x, y).itemHeld--;
    }
    private void RemoveItem(int x, int y) 
    {
        SetItem(null, x, y);
    }

    private bool TryAddItme(Item item, int x, int y) 
    {
        if (IsEmpty(x, y))
        {
            SetItem(item, x, y);
            return true;
        }
        else 
        {
            return false;
        }
    }
    private Item GetRecipeOutuput() 
    {
        foreach (Recipe_SO recipeSO in recipeSOList)
        {
            bool completeRecipe = true;
            for (int x = 0; x < GRID_SIZE; x++)
            {
                for (int y = 0; y < GRID_SIZE; y++)
                {     
                    if (recipeSO.GetItem(x, y) != null)
                    {
                        if (IsEmpty(x, y) || GetItem(x, y) != recipeSO.GetItem(x, y))
                        {
                            completeRecipe = false;
                        }
                    }
                }
            }
            if (completeRecipe) { return recipeSO.output; }
        }
        return null;
    }

    private void CreateOutput() 
    {
        Item recipeOutput = GetRecipeOutuput();
        if (recipeOutput == null)
        {  outputItem = null; }

        else { outputItem =  recipeOutput ; }
    }
    public Item GetOutputItem() 
    {
        return outputItem;
    }
}
