using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float health = 100.0f;
    public int brojBrodovaLv2 = 0;
    public static PlayerController instance;

    // Use this for initialization
    void Start()
    {
        health = 100.0f;
        instance = this;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Score.instance.healthSlider.value = health;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        // dodati gameover tekst i sve to
        Destroy(gameObject);
        Score.instance.rezultatText.text = "Score: " + Score.instance.brojBodova.ToString();
    }



}
