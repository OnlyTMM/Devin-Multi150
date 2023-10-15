using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour

{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public int countBounces = 0;
   void OnTriggerEnter (Collider other)
   {
        countBounces ++;
        print("Bounces " + countBounces);
        print("Bounced " + gameObject.name);
   }


   
  
  
}
