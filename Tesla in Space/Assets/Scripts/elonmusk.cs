using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class elonmusk : MonoBehaviour
{

    public AudioClip Background2Music;
    public AudioSource Music2Source;
   
   

    // Start is called before the first frame update
    void Start()
    {
        
        Music2Source.clip = Background2Music;
        Music2Source.Play();
        StartCoroutine(menu(5f));
        
    }

    // Update is called once per frame


    IEnumerator menu(float delay) {

        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene("MainMenu");
        yield return null;

    }
}
