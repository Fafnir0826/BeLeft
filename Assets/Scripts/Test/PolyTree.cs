using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyTree : MonoBehaviour
{
    public enum TreeType
    {
        Tree,
        treehalf,
        woodTwo,
        woodOne
    }

    public Durability treeDurability;
    [SerializeField] private TreeType treeType = TreeType.Tree;
    public GameObject treehalfTree;
    public GameObject treewoodTwo;
    public GameObject treewoodOne;

    private void Update()
    { 
        switchType(); 
    }


    void switchType()
    {
        if (treeDurability.currentDurability < 80 && treeDurability.currentDurability > 50) 
        {
            treeType = TreeType.treehalf;
           
        }
    }
    void switchState()
    {
        switch (treeType)
        {
            case TreeType.Tree:
                Instantiate(treewoodTwo,transform.position,transform.rotation);
                Instantiate(treewoodOne,transform.position,transform.rotation);
                Instantiate(treehalfTree, transform.position, transform.rotation);

                break;
            case TreeType.treehalf:
                Instantiate(treewoodTwo, transform.position, transform.rotation);
                Instantiate(treewoodOne, transform.position, transform.rotation);
                break;
            case TreeType.woodTwo:
                Instantiate(treewoodOne, transform.position, transform.rotation);
                break;
            case TreeType.woodOne:     
                break;

        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Axe")
        {
            treeDurability.currentDurability -= 10;
            switchState();
        }
    }

}
