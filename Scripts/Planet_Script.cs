using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Planet_Script : MonoBehaviour
{
    // Script used to check what hits a planet, with an appropriate action performed
    // By: Sachin Deshpande

    // Use this for initialization
    // Default method included when script is utilized
    void Start()
    {

    }

    // Update is called once per frame
    // Default method included when script is utilized
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {   
        // this script is applied to planet objects in the game's later levels.
        // if the player collides with this object and it is not the finish platform or the start platform, then the level should reset
        // second conditional is used to check the third level of game, where gameObjects may hit finish line. In this case, level should also be reset
        // if an enemy collides with this planet, then that object should be destroyed
        if (collision.gameObject.tag == "Player" && !(this.gameObject.name.Equals("Start_Platform")) &&  !(this.gameObject.name.Equals("Finish_Platform")))
        {
            // generic case of player hitting an obstacle (spaceship, planet, or other)
            // reset the level, as player has fatally collided
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.gameObject.tag == "Finish" && this.name.Equals("Finish_Platform"))
        {   
            // this condition is only possibly true in the third level
            // case of enemy hitting the finish line before the player has
            // reset level, as player failed to reach planet in given time
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else if (collision.gameObject.tag == "Finish" || collision.gameObject.tag == "Respawn")
        {   
            // generic collision detection for other levels
            // case of enemy object hitting an obstacle, and thus must be destroyed
            Destroy(collision.gameObject);
        }
        
    }
}
