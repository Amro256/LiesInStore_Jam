using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagment : MonoBehaviour
{
    // // Start is called before the first frame update
    // void Start()
    // {
        
    // }

    //Update is called once per frame

     void Update()
     {
        //Input for changing scene
        if(Input.GetKeyDown(KeyCode.Return)) //Return = Enter Key
        {
            //Debug.Log("Enter Key Pressed!"); Debugging Purposes

            //Change Scenes
            SceneManager.LoadScene("PrologueScene");
        }
     }    
}
