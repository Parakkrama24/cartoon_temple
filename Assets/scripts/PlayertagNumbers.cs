using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayertagNumbers : MonoBehaviour
{
 
 
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("plane01"))
        {
            Debug.Log(gameObject.transform.position);
        }       
        else if (other.gameObject.CompareTag("plane02"))
        {
            Debug.Log(gameObject.transform.position);
        }        
        else if (other.gameObject.CompareTag("plane03"))
        {
            Debug.Log(gameObject.transform.position);
        }        
        else if (other.gameObject.CompareTag("plane04"))
        {
            Debug.Log(gameObject.transform.position);
        }        
        else if (other.gameObject.CompareTag("plane0"))
        {
            Debug.Log(gameObject.transform.position);
        }

    }
}
