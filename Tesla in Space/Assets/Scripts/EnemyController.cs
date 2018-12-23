using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float zivoti = 20;
    public float brzina = 0.5f;

    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        GetComponent<Rigidbody2D>().velocity = new Vector2(0,
            -brzina) * 1;

        rb2d.angularVelocity = Random.Range(-200, 200);
    }

    void OnBecameInvisible()
    {
        // Destroy the enemy
        Destroy(gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }



}
