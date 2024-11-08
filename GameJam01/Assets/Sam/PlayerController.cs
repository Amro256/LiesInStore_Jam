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

    // Update is called once per frame
    void Update()
    {

        //float x = Input.GetAxis("Horizontal");
        //float z = Input.GetAxis("Vertical");

        //Updated Code
        movementX = Input.GetAxis("Horizontal");
        movementZ = Input.GetAxis("Vertical");

        
    }

    void FixedUpdate() 
    {
        //Movement moved into Fixed Updated as it's more appropriate
        Vector3 move = transform.right * movementX + transform.forward * movementZ;

        controller.Move(move * moveSpeed * Time.deltaTime);
        
    }
}
