using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.Tilemaps;
using UnityEngine;

public class TriangleScript : MonoBehaviour
{
    public Transform centerPoint;
    public float speed = 70f;
    bool isTriggered = false;
    public TargetScript targetScript;
    void Start()
    {
        targetScript = GameObject.FindGameObjectWithTag("Target").GetComponent<TargetScript>();
        
    }

    void Update()
    {
        transform.RotateAround(centerPoint.position, Vector3.forward, speed * Time.deltaTime);


        if (isTriggered && Input.GetMouseButtonDown(0))
        {
            targetScript.spawn();
            speed *= -1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Target")) return;
        isTriggered = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (!collision.CompareTag("Target")) return;
        isTriggered = false;
    }


}
