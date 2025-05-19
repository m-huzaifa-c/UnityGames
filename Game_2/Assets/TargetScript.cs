using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class TargetScript : MonoBehaviour
{
    const float RADIUS = -2.9f;


    private void Start()
    {
        spawn();
    }
    public void spawn()
    {
        float angle = UnityEngine.Random.Range(0f , 360f)  * Mathf.Deg2Rad;
        float xPos = RADIUS * Mathf.Cos(angle);
        float yPos = RADIUS * Mathf.Sin(angle);

        transform.position = new Vector3(xPos, yPos, transform.position.z);
        transform.rotation = Quaternion.Euler(0f, 0f, ( angle  * Mathf.Rad2Deg+ 90f ));
    }
}
