using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyProjectile : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 25;
    public Rigidbody2D rb;

    void Start()
    {
        rb.velocity = transform.up * speed;

        Scene scene = SceneManager.GetActiveScene();
        if (scene.name == "level3")
        {
            speed = 35f;
            damage = 20;
        }

    }
    void OnTriggerEnter2D(Collider2D hitInfo)
    {

        //Debug.Log("pogoden je:" + hitInfo.name);

        //da se ne sudara sa vlastitim colliderom
        if (hitInfo.gameObject.tag == "ENEMYship")
        {
            return;
        }
        //Enemy ship projektili se ne unistiavaju prilikom sudara sa projektilom naseg shipa
        if (hitInfo.gameObject.name == "Projectile(Clone)")
        {
            return;
        }

        if (hitInfo.gameObject.tag == "boss")
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
