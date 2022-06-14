using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{ 
    public GameObject button;
    
    public void MoveToGameScene()
    {
        SceneManager.LoadScene(1);
        
       
        button.SetActive(false);
    }

}
