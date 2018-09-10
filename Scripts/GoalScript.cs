using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour
{
    // Simple script used to advance through levels and exit the game
    // This is called when the user reaches the goal. Currently, "reaching the goal" is modeled as a
    // collision. 
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

    void OnCollisionEnter(Collision collision)
    {
        // Multiple objects can collide with the Finish_Platform, depending on level. 
        // Hence. check only for "player" colliding with platform. Ignore other collisions for level checking 
        // purposes
        if (collision.gameObject.tag == "Player")
        {
            // player has collided with Finish_Platform, go to next level
            NextLevel();
        }
    }

    private void NextLevel()
    {   
        // progress to the next level
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        // end of game has been reached, quit the game
        Application.Quit();
    }
}
