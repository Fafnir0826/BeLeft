using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyTree : MonoBehaviour
{
    public enum Type 
    {
        Tree,
        Log,
        LogHalf,
        Stump
    }

    [SerializeField]private Type treeType;

    private void Tree() 
    {
        switch (treeType) 
        {
            default:
            case Type.Tree:
                break;
            case Type.Log:
                 break;
            case Type.LogHalf:
                break;
            case Type.Stump:
                break;
               
                
        }
    }

}
