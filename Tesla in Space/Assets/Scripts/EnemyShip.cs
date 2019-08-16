using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyShip : MonoBehaviour
{

    public AudioClip MeteorMusic;
    public AudioSource MeteorSource;

    public EnemyShip instance;
    public int health = 200;
    private float timeLeft;

    private Rigidbody2D rb2d;

    public Text gameCompleted;

    public float WaitTime = 2.0f;


    void Start()
    {
        
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
        MeteorSource.clip = MeteorMusic;
        MeteorSource.Play();
        Destroy(this.gameObject);
        PlayerController.brojBrodovaLv2++;
        Score.brojBodova += 25;
        Score.rezultatText.text = "Score: " + Score.brojBodova.ToString();
        
        if (PlayerController.brojBrodovaLv2 == 3)
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
