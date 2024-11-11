using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstacle;
    PlayerController playerControllerScript;
    void Start()
    {
        InvokeRepeating("SpawnManagerFunction", 2, 3);
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {

    }

    void SpawnManagerFunction()
    {
        if (playerControllerScript.gameOver == false)
        {
            Instantiate(obstacle, new Vector3(25, 0, 0), obstacle.transform.rotation);
        }
    }
}
