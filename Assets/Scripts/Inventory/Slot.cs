using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slot : MonoBehaviour
{
    public Item slotItem;
    public Image slotImage;
    public Text slotNum;

    public GameObject itemInSlot;


    public void CreateObjects() 
    {
        //if (slotItem.selfObjects != null && slotItem.itemHeld > 1)
        //{
            Instantiate(slotItem.selfObjects, transform.position + Vector3.down, Quaternion.identity);
            slotItem.itemHeld -= 1;
            InventoryManager.RefreshItem();
            
       // }
    }

    public void SetupSlot(Item item) 
    {
        if (item == null) 
        {
            itemInSlot.SetActive(false);

            return;
        }

        slotImage.sprite = item.itemImage;
        slotNum.text = item.itemHeld.ToString();
        slotItem = item;
    }

}
