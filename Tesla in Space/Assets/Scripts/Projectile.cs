﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 40;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {

        Debug.Log(hitInfo.name);

        //da se ne sudara sa colliderom od igraca
        if (hitInfo.gameObject.name == "Player")
        {
            return;
        }

        Enemy enemy = hitInfo.GetComponent<Enemy>();
        EnemyShip enemyShip = hitInfo.GetComponent<EnemyShip>();

        if (enemyShip != null)
        {
            enemyShip.TakeDamage(damage);
        }
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        // Unisti projektil 
        Destroy(gameObject);
    }

}
