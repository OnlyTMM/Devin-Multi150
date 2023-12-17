using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveEvil : MonoBehaviour
{
    public float startSpeed = 20f;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody rigidBody = GetComponent<Rigidbody>();
        rigidBody.velocity = new Vector3(startSpeed, 0, startSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
