using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    //Zapisivanje bodova
    public Text rezultatText;
    public int brojBodova;
    public static Score instance;

    //zapisivanje health-a
    public Slider healthSlider;

    private void Start()
    {
        //ako je prva scena, resetira se broj osvojenih bodova, obavezno
        Scene scene = SceneManager.GetActiveScene();
        instance = this;
        if (scene.name == "level1")
        {
           PlayerPrefs.SetInt("Player Score", 0);
        }
        
        brojBodova = 0;
        instance = this;
        brojBodova = PlayerPrefs.GetInt("Player Score"); ;
        rezultatText.text = "Score: " + brojBodova;
        healthSlider.value = PlayerController.instance.health;

    }


}
