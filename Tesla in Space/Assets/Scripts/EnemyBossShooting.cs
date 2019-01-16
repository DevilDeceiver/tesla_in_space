using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBossShooting : MonoBehaviour
{
    public Transform firePoint;
    public Transform firePoint2;
    public Transform firePoint3;
    private Transform firePointTEMP;
    private Transform firePointTEMP2;
    public GameObject projectilePrefab;
    private float timer = 2f;

    private void Start()
    {
        StartCoroutine(coroutineA());
        firePointTEMP = firePoint;
        firePointTEMP2 = firePoint;
       // firePointTEMP.rotation = Quaternion.Euler(0, 0, 0);
        firePointTEMP2.rotation = Quaternion.Euler(0, 0, 0);
    }

    IEnumerator coroutineA()
    {

        while (true)
        {
            //enemy Boss firerate, 1000ms
            yield return new WaitForSeconds(0.4f);
            firePointTEMP.rotation = Quaternion.Euler(0, 0, 180);
            Instantiate(projectilePrefab, firePoint2.position, firePoint.rotation);
            Instantiate(projectilePrefab, firePoint3.position, firePoint.rotation);
            Instantiate(projectilePrefab, firePointTEMP2.position, firePoint.rotation);
            firePointTEMP.rotation = Quaternion.Euler(0, 0, 0);
        }

    }
}
