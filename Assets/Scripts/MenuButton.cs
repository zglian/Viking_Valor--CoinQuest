using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour
{
    
    public void ToMenu()
    {
        Debug.Log("0");
        SceneManager.LoadScene(0);
    }
    
}
