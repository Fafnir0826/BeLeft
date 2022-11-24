using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
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
            // playerInvnentory.itemLists.Add(thisItem);
            //InventoryManager.CreateNewItem(thisItem);
            for(int i = 0;i < playerInvnentory.itemLists.Count; i++) 
            {
                if (playerInvnentory.itemLists[i] == null) 
                {
                    playerInvnentory.itemLists[i] = thisItem;
                    break;
                }
            }
        }
        else
        {
            thisItem.itemHeld +=1;
        }
        InventoryManager.RefreshItem();
        Destroy(this.gameObject);
    }
}
