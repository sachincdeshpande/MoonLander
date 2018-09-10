using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mooooovement : MonoBehaviour {
    // Script used when an object (e.g. bullet) moves towards a point and resets back after a certain amount of time
    // By: Sachin Deshpande

    // fields that control how this object moves
    // declared public so unity may initialize correctly when specified in the development kit
    public Vector3 point1;                      // the object's current position
    public Vector3 point2;                      // point the object will go towards
    public Vector3 translator;                  // vector to translate the object back to original position
    public float speed;                         // how fast the object will move
    public double travelTime;                   // how long the object will travel for
    public double elapsedTime;                  // how much time has elapsed (used to reset object) 

    // Used for initialization
    // Default method included when script is utilized
    void Start ()
    {

    }

    // Update is called once per frame
    // Default method included when script is utilized
    void Update () {
        // update objects position. Will move speed amount from its current position to point2, the destination
        transform.position = Vector3.MoveTowards(transform.position, point2, speed);
        // check to see if object should be reset
        if ((double)(Time.time) > elapsedTime + travelTime)
        {   
            // this conditional evaluates to be true when the object has traveled for its travelTime
            // now it must be reset back to its starting point
            elapsedTime += travelTime;
            transform.position = point1;
        }
    }
}
