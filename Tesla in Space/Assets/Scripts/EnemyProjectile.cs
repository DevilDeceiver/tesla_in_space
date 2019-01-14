using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 25;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;

    }



    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        Debug.Log("pogoden je:" + hitInfo.name);

        //da se ne sudara sa vlastitim colliderom
        if (hitInfo.gameObject.tag == "ENEMYship")
        {
            return;
        }

        PlayerController player = hitInfo.GetComponent<PlayerController>();

        if (player != null)
        {
            player.TakeDamage(damage);
        }
        Destroy(gameObject);
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
