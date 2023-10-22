using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvilOne : MonoBehaviour
{   
    public bool isGood = false;
    void OnTriggerEnter(Collider collider)
    {
    GameObject collidedWith = collider.gameObject;
    if (collidedWith.tag == gameObject.tag);
    {
        isGood = true;
        GetComponent<Light>().enabled = false; 
        Destroy(collidedWith);
    }
    }
    
    }

