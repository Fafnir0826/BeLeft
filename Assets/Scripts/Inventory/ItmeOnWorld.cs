using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItmeOnWorld : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInvnentory;

    public void AddNewItem()
    {
        if(!playerInvnentory.itemLists.Contains(thisItem))
        {
            playerInvnentory.itemLists.Add(thisItem);
            InventoryManager.CreateNewItem(thisItem);
        }
        else
        {
            thisItem.itemHeld +=1;
        }
        InventoryManager.RefreshItem();
        Destroy(this.gameObject);
    }
}
