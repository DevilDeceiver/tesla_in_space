﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int health = 20;


   

    //public GameObject deathEffect;

    public void TakeDamage (int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();

        }
    }

    void Die()
    {
        
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Score.brojBodova+=10;
        Score.rezultatText.text ="Score: " + Score.brojBodova.ToString();
    }

    //kad meteor izade van ekrana, player dobije damage i unisti se meteor
    void OnBecameInvisible()
    {
       
        Destroy(gameObject);
    }
    //kolizija meteora sa igracem, damage je -25
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.name == "Projectile(Clone)") {
            return;
        }
        if (hitInfo.gameObject.tag == "Down")
        {
            return;
        }
        Debug.Log("Collided With: " + hitInfo.gameObject.name);
        //PlayerController player = hitInfo.GetComponent<PlayerController>();
        Destroy(gameObject);
        PlayerController.health -= 25;
        Score.healthSlider.value = PlayerController.health;

    }

}
