using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public Transform firePoint;
    public GameObject projectilePrefab;


    public AudioClip ShootingMusic;
    public AudioSource ShootingSource;


    void Update()
    {    
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        ShootingSource.clip = ShootingMusic;
        ShootingSource.Play();
        //firePoint.position = new Vector2(firePoint.position.x, firePoint.position.y + 2.0f); //nesto ne radi
        Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
    }

    
}
