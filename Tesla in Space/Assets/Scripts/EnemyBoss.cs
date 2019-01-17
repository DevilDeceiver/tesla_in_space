using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBoss : MonoBehaviour
{
    public EnemyBoss instance;
    public int health = 0;
    private float timeLeft;

    private Rigidbody2D rb2d;

    public float WaitTime = 2.0f;

    public Text gameCompleted;

    void Start()
    {
        gameCompleted.text = "";
        rb2d = GetComponent<Rigidbody2D>();
        instance = this;
        health = 1200;


    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        Debug.Log("Boss dbiva damage");
        if (health <= 0)
        {
            Die();

        }
    }
    void Die()
    {
        gameCompleted.text = "Game Completed\nCongratulations";
        Debug.Log("ubijen boss");
        Destroy(gameObject);
        PlayerController.instance.brojBrodovaLv2++;
        Score.instance.brojBodova += 225;
        Score.instance.rezultatText.text = "Score: " + Score.instance.brojBodova.ToString();

        //end game, load credits scenu
        
    }

}
