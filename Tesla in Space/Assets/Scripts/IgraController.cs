using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgraController : MonoBehaviour
{
    public GameObject neprijatelj;

    public float maxWidth;
    public float vrijemeSpawn = 3.0f;

    private void Start()
    {
        Vector3 upperCorner = new Vector3(Screen.width, Screen.height, 0.0f);
        Vector3 targetWidth = Camera.main.ScreenToWorldPoint(upperCorner);
        float ballWidth = neprijatelj.GetComponent<Renderer>().bounds.extents.x / 2;
        maxWidth = targetWidth.x - ballWidth;

        //pokretanje spawna neprijatelja
        StartCoroutine(Spawn());

    }

    IEnumerator Spawn()
    {
        // Čeka 2 sekunde
        yield return new WaitForSeconds(2.0f);
        // Beskonačna petlja
        while (true)
        {
            // Određuje poziciju iz koje će se instancirati kugle
            Vector3 spawnPosition = new Vector3(Random.Range(-maxWidth, maxWidth),
            transform.position.y, 0.0f);
            // Za rotaciju se uzima „default“ vrijednost (0, 0, 0, 0)
            Quaternion spawnRotation = Quaternion.identity;
            // Instanciranje kugle
            Instantiate(neprijatelj, spawnPosition, spawnRotation);
            // Čeka 2 sekunde
            yield return new WaitForSeconds(2.0f);
        }
    }
}
