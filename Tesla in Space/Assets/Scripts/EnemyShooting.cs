using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public Transform firePoint;
    private Transform firePointTEMP;
    public GameObject projectilePrefab;
    private float timer = 2f;

    private void Start()
    {
        StartCoroutine(coroutineA());
        firePointTEMP = firePoint;
        firePointTEMP.rotation = Quaternion.Euler(0, 0, 0);
    }

    IEnumerator coroutineA()
    {

        while (true)
        {
        //enemy ship firerate, 1000ms
        yield return new WaitForSeconds(1f);
            firePointTEMP.rotation = Quaternion.Euler(0, 0, 180);
            Instantiate(projectilePrefab, firePointTEMP.position, firePoint.rotation);
            firePointTEMP.rotation = Quaternion.Euler(0, 0, 0);
        }
        
    }
}
