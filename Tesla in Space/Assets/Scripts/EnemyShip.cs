using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyShip : MonoBehaviour
{
    public EnemyShip instance;
    public int health = 200;
    private float timeLeft;

    private Rigidbody2D rb2d;

    public Text gameCompleted;

    public float WaitTime = 2.0f;


    void Start()
    {
        gameCompleted.text = "";
        rb2d = GetComponent<Rigidbody2D>();
        instance = this;

        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "level2")
        {
           if (gameObject.name == "ship2") {
            health = 350;
                }
        }
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
        PlayerController.instance.brojBrodovaLv2++;
        Score.instance.brojBodova += 25;
        Score.instance.rezultatText.text = "Score: " + Score.instance.brojBodova.ToString();
        
        if (PlayerController.instance.brojBrodovaLv2 == 3)
        {
            Level2Controller.instance.ucitajLevel3();
        }
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
