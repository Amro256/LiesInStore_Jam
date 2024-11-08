using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taser : MonoBehaviour
{

    public float range = 100f;
    public float knockbackForce = 250;
    public float fireRate = 1f;
    public Camera fpsCam;
    public GameObject Enemy;

    private float nextTimeToFire = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate; 
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

           Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                KnockbackEnemy();
            }
        }
    }

    void KnockbackEnemy()
    {
        Enemy.transform.position += transform.forward * Time.deltaTime * knockbackForce;
    }
}