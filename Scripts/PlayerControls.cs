using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControls : MonoBehaviour {
    // Script used to control the player's object
    // By: Sachin Deshpande

    // fields that control the player's ship
    // declared public so unity may initialize correctly when specified in the development kit
    public float thrust_strength;                   // how much the spaceship will go up/down
    public float speed;                             // how much spaceship will go left/right

    Rigidbody rb;                                   // RigidBody to give spaceship collision

    // Used for initialization
    // Default method included when script is utilized
    void Start()
    {
        // initialize spaceship's collision
  	rb = this.GetComponent<Rigidbody>();        
    }

    // Update is called once per frame
    // Default method included when script is utilized
    void Update ()
    {
        // the player may press various keys to control their ship. 
        // the following conditionals check user input and appropriately affect ship
        // if user input is invalid, game remains unaffected, input is ignoted
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow)) {
            // make spaceship go up
	    rb.AddForce (new Vector3 (0, thrust_strength, 0));
	}
	if(Input.GetKey("a") || Input.GetKey(KeyCode.LeftArrow)) {
            // make spaceship go left
            rb.AddForce (new Vector3(-speed,0,0));
	}
	if (Input.GetKey ("d") || Input.GetKey(KeyCode.RightArrow)) {
            // make spaceship go right
            rb.AddForce (new Vector3 (speed, 0, 0));
	}
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            // make spaceship go down
            rb.AddForce(new Vector3(0, -thrust_strength, 0));
        }
        // User asking for help in a level. Even scenes are levels hence the check below.
        if (Input.GetKey("h") && (SceneManager.GetActiveScene().buildIndex % 2 == 0))
        {
            // go back a scene to allow player to view level prompt again
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        // update spaceship's position
        transform.position = new Vector3 (transform.position.x, transform.position.y, 0);
    }
}

