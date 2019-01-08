using System.Collections;
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
        Score.instance.brojBodova++;
        Score.instance.rezultatText.text = "Score: " + Score.instance.brojBodova.ToString() + ".";
    }

    //kad izade van ekrana, player dobije damage i unisti se meteor
    void OnBecameInvisible()
    {
        Destroy(gameObject);
        
    }
    //kolizija meteora sa igracem, damage je 10+15
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.name == "Projectile(Clone)") {
            return;
        }
            Debug.Log("Collided With: " + hitInfo.gameObject.name);
            PlayerController player = hitInfo.GetComponent<PlayerController>();
            Destroy(gameObject);
            PlayerController.instance.health -= 25;
            Score.instance.healthSlider.value = PlayerController.instance.health;

    }
}
