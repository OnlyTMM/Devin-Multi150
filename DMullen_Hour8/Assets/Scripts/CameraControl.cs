using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
 
{   private GameObject target;
    public float moveSpeed = 10f; 
    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Main Camera");

    }

    // Update is called once per frame
    void Update()
    {
    float xMouse = Input.GetAxis("Mouse X");
    float yMouse = Input.GetAxis("Mouse Y");
    transform.Translate(xMouse, 0f, yMouse);
    //When the mouse moves, the camera rotates in the direction of the position of the mouse
    
  
  


        
    }
}
