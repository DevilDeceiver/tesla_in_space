using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //Zapisivanje bodova
    public static Text rezultatText;
    public static int brojBodova = 0;

    

    //zapisivanje health-a
    public static Slider healthSlider;

    private void Awake()
    {
        rezultatText = GameObject.Find("Score").GetComponent<Text>();
        healthSlider= GameObject.Find("Slider").GetComponent<Slider>();
    }

    private void Start()
    {
        //ako je prva scena, resetira se broj osvojenih bodova, obavezno
        Scene scene = SceneManager.GetActiveScene();
     
        if (scene.name == "level1")
        {
           PlayerPrefs.SetInt("Player Score", 0);
        }
        
        brojBodova = 0;
     
        brojBodova = PlayerPrefs.GetInt("Player Score"); ;
        rezultatText.text = "Score: " + brojBodova;
        healthSlider.value = PlayerController.health;

    }


}
