using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jumpMove : MonoBehaviour
{
    private Rigidbody rb;
    //[SerializeField] private float jumpForce = 5f;
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            Debug.Log("prss");
         
        }
    }
}
