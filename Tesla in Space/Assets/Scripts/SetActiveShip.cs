using UnityEngine;
using System.Collections;

public class SetActiveShip : MonoBehaviour
{
    public GameObject gameObject;
    void Start()
    {
        //gameObject.SetActive(false);
        if(gameObject.name== "ship4(Clone)") {
            gameObject.SetActive(true);
        }
      
    }
}