using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadLevel : MonoBehaviour
  
{
    

    public void loadLvl() {


        print(PlayerController.LastLvl);
        SceneManager.LoadScene(PlayerController.LastLvl);
    }

   
}
