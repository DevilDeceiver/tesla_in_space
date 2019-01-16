using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Level2Controller : MonoBehaviour
{
    public static Level2Controller instance;

    public Text levelComplete;

    // Start is called before the first frame update
    void Start()
    {
       // shipEnemy = GameObject.FindGameObjectWithTag("ENEMYship");

        //provjera naziva scene, ako je level2 onda poziva spawn enemyShipova
        Scene scene = SceneManager.GetActiveScene();
        instance = this;
        if (scene.name == "level2")
        {
            Debug.Log("(trebao bi bit 2) - Active scene is '" + scene.name + "'.");
           
        }
    }
    public void ucitajLevel3()
    {
        StartCoroutine(UcitajLevel3(3f));
    }

    IEnumerator UcitajLevel3(float delay)
    {
        PlayerPrefs.SetInt("Player Score", Score.instance.brojBodova);
        levelComplete.text = "LEVEL 2 COMPLETE";
        yield return new WaitForSeconds(delay);
        levelComplete.text = "";
        SceneManager.LoadScene("level3");
        yield return null;
    }
}
