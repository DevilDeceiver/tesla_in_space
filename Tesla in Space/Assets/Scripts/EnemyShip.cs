using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
            Level2Controller.instance.PokreniSpawn();
            Die();

        }
    }
    void Die()
    {
        StartCoroutine(Level2Controller.instance.coroutineB());
        Destroy(gameObject);
        Score.instance.brojBodova += 25;
        Score.instance.rezultatText.text = "Score: " + Score.instance.brojBodova.ToString();
            
    }

    //Izbjegavanje enemyShip collisiona, za sad beskorisno
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        //da se ne sudara sa colliderom od susjednih shipova
        if (hitInfo.gameObject.tag == "ENEMYship")
        {
            return;
        }
    }
       

}
