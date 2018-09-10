using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ObstacleScript : MonoBehaviour {
    // Simple script used to check whether or not a player hits an obstacle
    // By: Sachin Deshpande

    // Use this for initialization
    // Default method included when script is utilized
    void Start ()
    {
		
	}

    // Update is called once per frame
    // Default method included when script is utilized
    void Update ()
    {
		
	}

    private void OnCollisionEnter(Collision collision)
    {   
        // this script is applied to objects in the game's early levels
        // if the player collides with this object, then the level will be reset
        // if the colliding object has the "finish" tag, it is deleted
        // multiple objects may collide with objects that utilize this script, thus conditionals below
        // check to see what action shall follow according to the object's data
        if(collision.gameObject.tag == "Player" && collision.gameObject.name == "Spaceship")
        {   
            // case of player hitting this object, reload scene/level
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if(collision.gameObject.tag == "Finish")
        {   
            // case of object with "finish" tag colliding with this object, destroy it
            Destroy(collision.gameObject);
        }
    }
}
