using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectilePrefab;


    private void Start()
    {
        //firePoint.position = new Vector2(firePoint.position.x, firePoint.position.y + 7.0f);
        
    }
    // Update is called once per frame
    void Update()
    {    
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        //firePoint.position = new Vector2(firePoint.position.x, firePoint.position.y + 2.0f); //nesto ne radi
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }

    
}
