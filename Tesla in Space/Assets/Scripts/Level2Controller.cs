﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Controller : MonoBehaviour
{
    public static Level2Controller instance;


    public Transform spawnPoint;
    public GameObject Player2;

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
            // StartCoroutine(coroutineB());
        }
    }
}
