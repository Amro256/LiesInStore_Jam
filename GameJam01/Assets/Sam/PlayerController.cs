using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 12f;

    public CharacterController controller;

    float movementX;
    float movementZ;

    public GameObject CanvasPanel; //Reference to UI Canvas
    public bool isPaused;  //Bool to check if the game is paused

    public Camera cam; //Reference to cam

     void Start()
    {
        CanvasPanel.SetActive(false);
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //Updated Code
        movementX = Input.GetAxis("Horizontal");
        movementZ = Input.GetAxis("Vertical");

        //Pause

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
        
    }

    void FixedUpdate() 
    {
        //Movement moved into Fixed Updated as it's more appropriate
        Vector3 move = transform.right * movementX + transform.forward * movementZ;

        controller.Move(move * moveSpeed * Time.deltaTime);
        
    }

    //Pause Game method

    public  void PauseGame()
    {
        CanvasPanel.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    //Resume Game Script

    public void ResumeGame()
    {
        CanvasPanel.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
}
