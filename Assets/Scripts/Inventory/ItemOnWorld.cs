using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemOnWorld : MonoBehaviour
{
    public Item thisItem;
    public Inventory playerInvnentory;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bag"))
        {
            AddNewItem();
            Destroy(gameObject);
        }
        if (other.gameObject.CompareTag("Weapon")) 
        {
            if (thisItem.dropObjects != null)
            {
                Instantiate(thisItem.dropObjects, other.gameObject.transform.position, Quaternion.identity);
            }
        }
    }

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
