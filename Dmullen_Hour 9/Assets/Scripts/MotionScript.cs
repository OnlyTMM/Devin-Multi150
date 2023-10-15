using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Input.GetAxis("Horizontal") * Time.deltaTime * 5;
        float yMove = Input.GetAxis("Vertical") * Time.deltaTime * 5;
        transform.Translate (xMove,yMove,0);
  
 
        
    }
}
