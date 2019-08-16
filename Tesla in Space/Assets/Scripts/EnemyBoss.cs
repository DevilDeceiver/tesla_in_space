using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyBoss : MonoBehaviour
{


    public AudioClip ShootingMusic;
    public AudioSource ShootingSource;


   
    public EnemyBoss instance;
    public float health = 1200f;
    private float timeLeft;
    //public static Scene level = SceneManager.GetActiveScene().name;

    public Slider bossSlider;

    private Rigidbody2D rb2d;

    public float WaitTime = 2.0f;

    public Text gameCompleted;

    private GameObject obj;

   

    void Start()
    {
        
        ShootingSource.clip = ShootingMusic;
        ShootingSource.Play();
        bossSlider = GameObject.Find("BossSlider").GetComponent<Slider>();
        print(bossSlider);
        gameCompleted.text = "";
        rb2d = GetComponent<Rigidbody2D>();



    }

    public void TakeDamage(int damage)
    {
        health -= damage;

       
        bossSlider.value = health;
        print("Boss dbiva damage");
        if (health <= 0)
        {
            StartCoroutine(Die(3f));

        }
    }

    public void Die()
    {
        StartCoroutine(Die(3f));
    }


    IEnumerator Die(float delay)
    {
        ShootingSource.Stop();
        SceneManager.LoadScene("ElonMusk");
        Destroy(gameObject);
        PlayerController.brojBrodovaLv2++;
        Score.brojBodova += 225;
        Score.rezultatText.text = "Score: " + Score.brojBodova.ToString();
        yield return new WaitForSeconds(delay);
        
        yield return null;
        //SceneManager.LoadScene("MainMenu");
        //end game, load credits scenu

    }

}
