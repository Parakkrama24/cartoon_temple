using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playernewAnimation : MonoBehaviour
{
    private Animator animator;
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

 
    void Update()
    {
        if(animator != null) { 
        
            if(Input.GetKeyUp(KeyCode.J))
            {
                animator.SetTrigger("onelegJump");
               Rigidbody rb = GetComponent<Rigidbody>();
                rb.AddForce(0,500,0,ForceMode.Impulse);
            }
        
        
        }
    }
}
