using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float movingSpeed;

    // Start is called before the first frame update
    void Start()
    {
        movingSpeed = 15f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(movingSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f, movingSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
    }
}
