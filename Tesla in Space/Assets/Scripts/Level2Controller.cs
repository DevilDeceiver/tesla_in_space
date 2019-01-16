using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Controller : MonoBehaviour
{
    public static Level2Controller instance;
    //stvaranje enemy shipova
    public Transform spawnPoint;
    public GameObject enemyShip;

    // Start is called before the first frame update
    void Start()
    {
        //provjera naziva scene, ako je level2 onda poziva spawn enemyShipova
        Scene scene = SceneManager.GetActiveScene();
        instance = this;
        if (scene.name == "level2")
        {
            Debug.Log("(trebao bi bit 2) - Active scene is '" + scene.name + "'.");
           // StartCoroutine(coroutineB());
        }
    }
    public void PokreniSpawn()
    {
        StartCoroutine(coroutineB());
    }

    //spawn enemy shipova
    public IEnumerator coroutineB()
    {
            //enemy ship spawnRate
            yield return new WaitForSeconds(3f);
            //Vector3 spawnPosition = new Vector3(transform.position.x, transform.position.y, 0f);
            //Quaternion spawnRotation = Quaternion.identity;
            Instantiate(enemyShip, spawnPoint.position, spawnPoint.rotation);

    }

}
