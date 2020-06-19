using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionLogger : MonoBehaviour
{

    private LogCollisions logger; 
    private void OnCollisionEnter(Collision collision)
    {
        logger = GameObject.Find("Communicator").GetComponent<LogCollisions>();
        Debug.Log(gameObject.name + " collided with " + collision.gameObject.name);
        logger.sendToLog("I hit something!");
    }
}
