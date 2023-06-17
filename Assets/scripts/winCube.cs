using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCube : MonoBehaviour
{
    public GameObject door;
    public scleiton _scelionScript;
    int x;
    //bool y;
    int z;
 
    
    void Update()
    {
        int winPoint = _scelionScript.points(x);
        //bool iswin = _scelionScript.point(y);
        int _newBonas=_scelionScript.bonas(z);
        if ( _scelionScript != null)
        {
            if(winPoint>=150 && _newBonas>=200)
            {
                door.SetActive(false);
            }
        }
    }
}
