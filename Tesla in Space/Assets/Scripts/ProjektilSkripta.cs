using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjektilSkripta : MonoBehaviour
{
    public float brzina = 5;
    private Rigidbody2D rb2d;
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        // Make the bullet move upward
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,
            brzina) * 1;
        //original
        // = new Vector2(horizontal,  0) *brzina;
    }
    
    // Function called when the object goes out of the screen
    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }
}
