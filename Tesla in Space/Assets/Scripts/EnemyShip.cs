using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public EnemyShip instance;
    public int health = 200;

    public float accelerationTime = 2f;
    public float maxSpeed = 5f;
    private float timeLeft;
    private Vector2 movement;

    private Rigidbody2D rb2d;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        instance = this;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();

        }
    }
    void Die()
    {
        Destroy(gameObject);
        Score.instance.brojBodova += 25;
        Score.instance.rezultatText.text = "Score: " + Score.instance.brojBodova.ToString();
        
    }

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f));
            timeLeft += accelerationTime;
        }
    }

    void FixedUpdate()
    {
        rb2d.AddForce(movement * maxSpeed);
        //rb2d.position = new Vector2(0, -3);
        //Debug.Log("Pomicanje2\n");
    }



}
