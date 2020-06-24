using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionLogger : MonoBehaviour
{
    private float secondsPassed = 0;

    private void Start()
    {
        StartCoroutine(nameof(TimeBeforeCollision), secondsPassed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(gameObject.name + " collided with " + collision.gameObject.name);
    }

    private IEnumerator TimeBeforeCollision(float secondsPassed)
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            secondsPassed++;
            Debug.Log("Seconds passed: " + secondsPassed.ToString());
        }
    }
}
