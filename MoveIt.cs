using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;

public class MoveIt : MonoBehaviour
{
    public int minDegrees = 30;
    public int maxDegrees = 30;

    public float rotationSpeed = 20f;

    public Vector3 rotationAxis;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //update is called once per frame
    void Update()
    {
            
        float angle = Mathf.PingPong(Time.time * rotationSpeed, minDegrees + maxDegrees) - minDegrees;

        transform.localRotation = Quaternion.AngleAxis(angle, rotationAxis);
    }
}
