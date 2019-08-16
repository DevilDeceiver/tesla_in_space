using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using  UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public static float health = 100.0f;
    public static int brojBrodovaLv2 = 0;
    public int damage;

    

    public static string LastLvl;

    private void Awake()
    {
        LastLvl = SceneManager.GetActiveScene().name;
    }

    // Use this for initialization
    void Start()
    {
        health = 100.0f;
     
    }


    private void Update()
    {
        TakeDamage(damage);
    }


    public void TakeDamage(int damage)
    {
        
       
        health -= damage;
        Score.healthSlider.value = health;
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

       
        // dodati gameover tekst i sve to
        gameObject.GetComponent<Renderer>().enabled = false;
        Score.rezultatText.text = "Score: " + Score.brojBodova.ToString();
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("RestartMenu");
        yield return null;



    }

    


}
