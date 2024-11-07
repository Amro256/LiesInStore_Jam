using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int pMaxHealth = 1;
    public int pCurrentHealth = 1;
    // Start is called before the first frame update
    void Start()
    {
        pCurrentHealth = pMaxHealth;
    }

    void TakeDamage(int amount)
    {
        pCurrentHealth -= amount;

        if(pCurrentHealth < 0)
        {
            //Dead character
            //Play animation or game over scene 
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
