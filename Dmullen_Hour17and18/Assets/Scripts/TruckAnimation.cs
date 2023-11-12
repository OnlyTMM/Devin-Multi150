using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TruckAnimation : MonoBehaviour
{
   public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("D was Pressed");
            anim.Play("TruckSpin");
        }
          if(Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A was Pressed");
            anim.Play("Truckcolor");
        }    
         if(Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("S was Pressed");
            anim.Play("Truckfloat");
        }
        if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("W was Pressed");
            anim.Play("Trucksize");
        }        
    }
}
