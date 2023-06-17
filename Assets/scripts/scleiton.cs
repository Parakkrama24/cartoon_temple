using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

public class scleiton : MonoBehaviour
{
    [SerializeField]private Animator animator;
    [SerializeField] private EnterPlaymode enterPlayMode;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private TextMeshProUGUI Bonustext;
    public int result;
    bool isth = false;
    int _bonas = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("box1") && enterPlayMode.IsOneleg)
        {
           
            points(1);
        }
               
        if (other.gameObject.CompareTag("box2") && enterPlayMode.IsOneleg)
        {
            
            points(2);
        }
               
        if (other.gameObject.CompareTag("box3") && !enterPlayMode.IsOneleg)
        {
            
            points(3);
        }
               
        if (other.gameObject.CompareTag("box4") && !enterPlayMode.IsOneleg)
        {
            
                points(4);
        }
               
        if (other.gameObject.CompareTag("box5") && enterPlayMode.IsOneleg)
        {
            
           points(5);
        }
               
        if (other.gameObject.CompareTag("box6") && !enterPlayMode.IsOneleg)
        {
          
            points(7);
        }
               
        if (other.gameObject.CompareTag("box7") && !enterPlayMode.IsOneleg)
        {
            
            points(7);
        }
               
        if (other.gameObject.CompareTag("box8") && enterPlayMode.IsOneleg)
        {
            
            points(8);
        }
               
        if (other.gameObject.CompareTag("box9") && !enterPlayMode.IsOneleg)
        {
       
            points(9);
        }
               
        if (other.gameObject.CompareTag("box10") && !enterPlayMode.IsOneleg)
        {
            point(true);
           bonas(100);
            points(10);
        }

       
    }

    public int points(int x)
    {
        result= result + x;
        text.text = "Points : " + result.ToString();
        //Debug.Log(result);
        return result;
    }

    public bool point(bool x)
    { 
        isth = x;
        //Debug.Log(isth);
        return isth;
    }

    public int bonas(int x)
    {
        _bonas =_bonas+x;
        Bonustext.text = "Bonus : " + _bonas.ToString();
        //Debug.Log(_bonas);
        return _bonas;
    }

    
}
