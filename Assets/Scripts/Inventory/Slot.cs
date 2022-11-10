using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Slot : MonoBehaviour
{
    public Item slotItem;
    public Image slotImage;
    public Text slotNum;


    public void CreateObjects() 
    {
        Instantiate(slotItem.selfObjects,transform.position+Vector3.down,Quaternion.identity);
        slotItem.itemHeld -= 1;
    }

}
