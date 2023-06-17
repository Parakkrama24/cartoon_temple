
using UnityEngine;
using UnityEngine.SceneManagement;


public class Uiscripts : MonoBehaviour
{
    public GameObject panal;

    public void GuidBT()
    {
      
        panal.SetActive(true);
    }

    public void backMenu()
    {
        SceneManager.LoadScene(0);
    }
}
