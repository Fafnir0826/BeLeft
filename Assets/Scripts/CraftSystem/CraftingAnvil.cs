using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CraftingAnvil : MonoBehaviour
{
    [SerializeField] private Image recipeImage;
    [SerializeField]private List<CraftingRecipe_SO> craftingRecipeSOList;
    [SerializeField] private BoxCollider placeItmeAreaBoxCollider;
    [SerializeField] private Transform itemSpawnPoint;
    [SerializeField] private Transform vfxSpawnItem;
    public int test =0;
    

    private CraftingRecipe_SO craftingRecipeSO;

    private void Awake()
    {
        NextRecipe();
        
    }

    private void Update()
    {
        if (test ==1) 
        {
            Craft();
        }
      
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

        foreach (Collider collider in colliderArray) 
        {
           
            /*if (collider.TryGetComponent(out ItemHolder itemHolder)) 
            {
                Debug.Log(collider);
                if (inputItemList.Contains(itemHolder.item)) 
                {
                    inputItemList.Remove(itemHolder.item);
                    consumeItemGameObjectList.Add(collider.gameObject);
                }
            }*/
            if (collider.TryGetComponent(out ItemOnWorld itemOnWorld))
            {
                Debug.Log(collider);
                if (inputItemList.Contains(itemOnWorld.thisItem))
                {
                    inputItemList.Remove(itemOnWorld.thisItem);
                    consumeItemGameObjectList.Add(collider.gameObject);
                }
            }
        }

        if (inputItemList.Count == 0) 
        {
            Transform spawnedItemTranform = 
                 Instantiate(craftingRecipeSO.outputItem.prefab, itemSpawnPoint.position, itemSpawnPoint.rotation);

            Instantiate(vfxSpawnItem, itemSpawnPoint.position, itemSpawnPoint.rotation);

            foreach (GameObject consumeItemGameObejct in consumeItemGameObjectList) 
            {
                Destroy(consumeItemGameObejct);
            }
          
        }

    }
}
