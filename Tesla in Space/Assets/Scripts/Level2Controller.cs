using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2Controller : MonoBehaviour
{
    public static Level2Controller instance;
    public Text levelComplete;
    public Text timeLeftText;
    public float timeLeft = 20;


    public AudioClip Background2Music;
    public AudioSource Music2Source;

    // Start is called before the first frame update
    void Start()
    {
        Music2Source.clip = Background2Music;
        Music2Source.Play();
        levelComplete.text = "";
        // shipEnemy = GameObject.FindGameObjectWithTag("ENEMYship");

        //provjera naziva scene, ako je level2 onda poziva spawn enemyShipova
        Scene scene = SceneManager.GetActiveScene();
        instance = this;
        if (scene.name == "level2")
        {
            Debug.Log("(trebao bi bit 2) - Active scene is '" + scene.name + "'.");
           
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        timeLeft = timeLeft - Time.deltaTime;
        if (timeLeft <= 0)
        {
            Music2Source.Stop();
            print("hey");
            timeLeft = 0;
            StartCoroutine(UcitajLevel3(3f));
        }
        // Koristi se Mathf.RountToInt kako bi vrijeme bilo bez decimalnih brojeva
        timeLeftText.text = "Preostalo vrijeme: " + Mathf.RoundToInt(timeLeft);
    }


    public void ucitajLevel3()
    {
        StartCoroutine(UcitajLevel3(3f));
    }

    IEnumerator UcitajLevel3(float delay)
    {
        PlayerPrefs.SetInt("Player Score", Score.brojBodova);
        levelComplete.text = "LEVEL 2 COMPLETE";
        yield return new WaitForSeconds(delay);
        levelComplete.text = "";
        SceneManager.LoadScene("level3");
        yield return null;
    }
}
