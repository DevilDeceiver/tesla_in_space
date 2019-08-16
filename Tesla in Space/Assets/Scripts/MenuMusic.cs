using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{


    public AudioClip menumusic;
    public AudioSource menusource;
    // Start is called before the first frame update
    void Start()
    {
        menusource.clip = menumusic;
        menusource.Play();
    }

    // Update is called once per frame
   
}
