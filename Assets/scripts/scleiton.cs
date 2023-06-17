using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scleiton : MonoBehaviour
{
    [SerializeField]private Animator animator;
    [SerializeField] private EnterPlaymode enterPlayMode;
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("box1") && enterPlayMode.IsOneleg)
        {
            Debug.Log(gameObject.name);
        }
    }
}
