using Oculus.Interaction;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PolyTree : MonoBehaviour
{

    public Durability treeDurability;
    public GameObject treewoodTwo;

    private void Update()
    { 
        if(treeDurability.currentDurability <= 0) 
        {
            Destroy(gameObject);
        }
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Axe")
        {
            treeDurability.currentDurability -= 1;
            Vector3 offset = transform.position + new Vector3(Random.Range(0.5f, -0.5f), transform.position.y + 1.0f, Random.Range(0.5f, -0.5f));
            Instantiate(treewoodTwo, offset, Quaternion.identity);
        }
    }

}
