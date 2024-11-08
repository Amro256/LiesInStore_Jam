using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentScript : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject flashlight;
    public GameObject taser;

    //Variables for the light source to enable and disable it
    

    

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            EquipFlashlight();
        }

        if (Input.GetKeyDown("2"))
        {
            EquipTaser();
        }
    }

    void EquipFlashlight()
    {
        flashlight.SetActive(true);
        taser.SetActive(false);
    }

    void EquipTaser()
    {
        flashlight.SetActive(false);
        taser.SetActive(true); 
    }
}
