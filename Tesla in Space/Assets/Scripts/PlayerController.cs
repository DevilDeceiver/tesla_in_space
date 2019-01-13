using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float health = 100.0f;
    public static PlayerController instance;

    // Use this for initialization
    void Start()
    {
        instance = this;
    }

    

}
