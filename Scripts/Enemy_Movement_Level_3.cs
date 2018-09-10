using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Movement_Level_3 : MonoBehaviour
{
    // Simple script used to make an object approach a specified vector
    // By: Sachin Deshpande
    public Vector3 destination;
    public float speed = .05F;

    // Used for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, destination, speed);
    }
}
