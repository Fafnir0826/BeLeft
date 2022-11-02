using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_CraftingSystem : MonoBehaviour
{
   
    private Transform[,] slotTransformArray;
    private Transform outputSlotTransfrom;

    private void Awake()
    {
        Transform gridContainer = transform.Find("gridContainer");

        slotTransformArray = new Transform[CraftingSystem.GRID_SIZE, CraftingSystem.GRID_SIZE ];
        
        for (int x = 0; x < CraftingSystem.GRID_SIZE; x++) 
        {
            for (int y = 0; y < CraftingSystem.GRID_SIZE; y++) 
            {
                slotTransformArray[x,y] = gridContainer.Find("gird_"+ x + "_" + y);
            }
        }

        outputSlotTransfrom = transform.Find("outputSlot");
    }

    private void CreateItem(int x, int y, Item item) 
    {

    }
}
