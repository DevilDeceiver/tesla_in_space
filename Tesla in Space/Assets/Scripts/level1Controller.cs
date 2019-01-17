using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class level1Controller : MonoBehaviour
{
    public Text levelComplete;
    public Text timeLeftText;
    public float timeLeft = 30;
    public static level1Controller instance;
    // Start is called before the first frame update
    void Start()
    {
        levelComplete.text = "";
        timeLeftText.text = "Preostalo vrijeme: " + Mathf.RoundToInt(timeLeft);
        
        instance = this;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        timeLeft = timeLeft - Time.deltaTime;
        if (timeLeft < 0)
        {
            timeLeft = 0;
            StartCoroutine(UcitajLevel2(3f));
        }
        // Koristi se Mathf.RountToInt kako bi vrijeme bilo bez decimalnih brojeva
        timeLeftText.text = "Preostalo vrijeme: " + Mathf.RoundToInt(timeLeft);
    }

    IEnumerator UcitajLevel2(float delay)
    {
        PlayerPrefs.SetInt("Player Score", Score.instance.brojBodova);
        levelComplete.text = "LEVEL 1 COMPLETE";
        yield return new WaitForSeconds(delay);
        levelComplete.text = "";
        SceneManager.LoadScene("level2");
        yield return null;
    }


}
