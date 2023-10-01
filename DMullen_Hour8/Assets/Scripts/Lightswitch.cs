using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lightswitch : MonoBehaviour
{public Light Lightbulb;
 private bool usable = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.L) && usable){ 
        Lightbulb.enabled = !Lightbulb.enabled;

      }


      
    }
}
