using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
        instance = this;
        brojBodova = 0;
        rezultatText.text = "Score: " + brojBodova + ".";
        
    }


}
