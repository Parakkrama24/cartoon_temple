using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class numbers : MonoBehaviour
{
    [SerializeField]private Texture[] newTexture;
    [SerializeField] private GameObject[] planes;

    private Renderer[] Renderers;
    private Material[] Mat;

    void Start()
    {for(int i = 0; i < planes.Length; i++)
        {
          //Renderers[i]=  planes[i].GetComponent<Renderer>();
            Mat[i] = Renderers[i].material;
            Mat[i].mainTexture = newTexture[i];
        }
        //Renderer renderer = GetComponent<Renderer>();
        //Material material = renderer.material;
        //material.mainTexture = newTexture1;
    }

  
    void Update()
    {
        
    }
}
