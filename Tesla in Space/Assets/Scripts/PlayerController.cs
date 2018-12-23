using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public float brzina;
    public float zivoti = 30;

    public Text zivotiText;

    public GameObject projektil;

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //pokretanje spawn neprijatelja
       

        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            // Create a new bullet at “transform.position” 
            // Which is the current position of the ship
            // Quaternion.identity = add the bullet with no rotation
            Instantiate(projektil, transform.position, Quaternion.identity);
        }
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
     {
            // Dohvat pomaka po vertikalnoj osi
            float horizontal = Input.GetAxis("Horizontal");
            // Pomicanje objekta
            GetComponent<Rigidbody2D>().velocity = new Vector2(horizontal,
            0) * brzina;
     }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        zivoti = zivoti - 10;
        zivotiText.text = "Zivoti: " + zivoti;        
    }


}
