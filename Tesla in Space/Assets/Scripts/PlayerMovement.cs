using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 15;

    private float highestPosition=0;
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.

    // Use this for initialization
    void Start()
    {
        //Get and store a reference to the Rigidbody2D component so that we can access it.
        rb2d = GetComponent<Rigidbody2D>();
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void Update()
    {
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");


        ////Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Pokretanje broda
        rb2d.velocity = movement * speed;
    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        if (hitInfo.gameObject.tag == "Down")
        {
            rb2d.position = new Vector2(rb2d.position.x, -4.9f);
        }

        if (hitInfo.gameObject.tag == "left")
        {
            rb2d.position = new Vector2(-6.2f,rb2d.position.y);
        }

        if (hitInfo.gameObject.tag == "right")
        {
            rb2d.position = new Vector2(6.2f, rb2d.position.y);
        }
    }
}