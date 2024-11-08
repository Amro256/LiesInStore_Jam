using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    //Restart Game Method 
    
    // public void RestartGame()
    // {
    //     SceneManager.LoadScene("ControlScreen");
    // }
    //Quit game method 
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }
    
}
