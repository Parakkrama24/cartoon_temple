using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterPlaymode : MonoBehaviour
{
    private Animator animator;
    public int layerIndex=1;
    public float targetWeight=1;
    private Rigidbody rb;
    private bool isfreez;
   public bool IsOneleg;
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        if(animator != null) { 
        
            if(Input.GetKeyDown(KeyCode.Q) && layerIndex==1)
            {
                animator.SetLayerWeight(layerIndex, targetWeight);
                animator.SetLayerWeight(layerIndex-1, 0);
                layerIndex = 0;
                isfreez= true;
            }

            if (Input.GetKeyDown(KeyCode.Z) && layerIndex==0)
            {
                animator.SetLayerWeight(layerIndex, targetWeight);
                animator.SetLayerWeight(layerIndex+1, 0);

                layerIndex= 1;
            }
        
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            rb.constraints = RigidbodyConstraints.None;
            animator.SetTrigger("onelegJump");
            
        }
        else
        {
            if (isfreez)
            {
                rb.constraints = RigidbodyConstraints.FreezeAll;
            }
        }
        if(Input.GetKey(KeyCode.J))
        {
            animator.SetBool("onlegJumpHold",false);
            IsOneleg=true;
        }
        else
        {
            animator.SetBool("onlegJumpHold", true);
            IsOneleg = false;
        }
    }
}
