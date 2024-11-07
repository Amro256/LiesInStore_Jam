using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{

    public static SceneManagment Instance; //Singleton for global access 

    //Use Void Awake to set up the 
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this; //Set the Instance
            DontDestroyOnLoad(gameObject); //Dont destory the game manager object when loading/swapping scenes
        }
        else
        {
            // If there's an Instance already present then destory it 
            Destroy(gameObject);
        }

    }

    //Update is called once per frame

     void Update()
     {
        string currentScene = SceneManager.GetActiveScene().name;
        //Input for changing scene
        if(Input.GetKeyDown(KeyCode.Return)) //Return = Enter Key
        {
            //Debug.Log("Enter Key Pressed!"); Debugging Purposes

            //Check what the current scene is set to

            if(currentScene == "ControlScreen")
            {
                //Change Scenes
                 SceneManager.LoadScene("PrologueScene");
            }
            else if(currentScene == "PrologueScene")
            {
                SceneManager.LoadScene("Blockout");
            }

            
        }
     }    


    //Quit game method 
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Application Quit");
    }


}
