using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class putevi : MonoBehaviour
{
    //Hardkodiran broj node-ova unutar unitya
    public int brojNodeaPath1 = 0;
    public int brojNodeaPath2 = 0;
    public int brojNodeaPath3 = 0;
    public int brojNodeaPath4 = 0;
    public int brojNodeaPathTEMP = 0;
    int randomBroj = 0;

    public GameObject[] PathNode;
    public GameObject[] PathNode2;
    public GameObject[] PathNode3;
    public GameObject[] PathNode4;
    public GameObject[] PathNodeTEMP;
    public GameObject Player;
    public float MoveSpeed;
    float Timer;
    static Vector3 CurrentPositionHolder;
    int CurrentNode;
    private Vector2 startPosition;



    // Use this for initialization
    void Start()
    {
        //Player.SetActive(true);
        //random brzina kretanja po nodovima
        MoveSpeed = Random.Range(1.2f, 1.5f);
        randomBroj = Random.Range(1, 1); // {1,4} ukljuceni brojevi
        Debug.Log("Random broj putanje je : " + randomBroj);
        //random biranje putanje kretanja
        switch (randomBroj)
        {
            case 1:
                PathNodeTEMP = PathNode;
                brojNodeaPathTEMP = brojNodeaPath1;
                break;
            case 2:
                PathNodeTEMP = PathNode2;
                brojNodeaPathTEMP = brojNodeaPath2;
                break;
            case 3:
                PathNodeTEMP = PathNode3;
                brojNodeaPathTEMP = brojNodeaPath3;
                break;
            case 4:
                PathNodeTEMP = PathNode4;
                brojNodeaPathTEMP = brojNodeaPath4;
                break;
        }
        CheckNode();
    }

    void CheckNode()
    {
        Timer = 0;
        startPosition = Player.transform.position;
        if(CurrentNode == brojNodeaPathTEMP - 1)
        {
            CurrentNode = 0;
        }
        CurrentPositionHolder = PathNodeTEMP[CurrentNode].transform.position;

    }

    // Update is called once per frame
    void Update()
    {

        Timer += Time.deltaTime * MoveSpeed;

        if (Player.transform.position != CurrentPositionHolder)
        {
            Player.transform.position = Vector3.Lerp(startPosition, CurrentPositionHolder, Timer);
        }
        else
        {

            if (CurrentNode < PathNodeTEMP.Length - 1)
            {
                CurrentNode++;
                CheckNode();
            }
        }
    }

}