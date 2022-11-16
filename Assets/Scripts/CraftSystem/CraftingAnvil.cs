using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingAnvil : MonoBehaviour
{
    [SerializeField] private Image recipeImage;
    [SerializeField]private List<CraftingRecipe_SO> craftingRecipeSOList;
    [SerializeField] private BoxCollider placeItmeAreaBoxCollider;

    private CraftingRecipe_SO craftingRecipeSO;

    private void Awake()
    {
        NextRecipe();
        
    }

    public void NextRecipe() 
    {
        if (craftingRecipeSO == null) { craftingRecipeSO = craftingRecipeSOList[0]; }
        else 
        {
            int index = craftingRecipeSOList.IndexOf(craftingRecipeSO);
            index = (index + 1) % craftingRecipeSOList.Count;
            craftingRecipeSO = craftingRecipeSOList[index];
        }

        recipeImage.sprite = craftingRecipeSO.sprite;
    }

    public void Craft() 
    {
        Collider[] colliderArray = Physics.OverlapBox(transform.position + placeItmeAreaBoxCollider.center,
            placeItmeAreaBoxCollider.size,
            placeItmeAreaBoxCollider.transform.rotation);
        List<Item> inputItemList = new List<Item>(craftingRecipeSO.inputItemList);
        List<GameObject> consumeItemGameObjectList = new List<GameObject> ();


    }
}
