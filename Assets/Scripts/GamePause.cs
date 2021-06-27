using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePause : MonoBehaviour
{
    [SerializeField] private GameObject player, pauseButton, continueButton, menuButton, cam;
    private float tempGrav, tempVelocity, tempPipeSpeed;
    public void PauseGame()
    {
        tempPipeSpeed = cam.GetComponent<PipesController>().speed;
        cam.GetComponent<PipesController>().speed = 0f;
        tempGrav = player.GetComponent<Rigidbody2D>().gravityScale;
        player.GetComponent<Rigidbody2D>().gravityScale = 0f;
        tempVelocity = player.GetComponent<Rigidbody2D>().velocity.y;
        player.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        player.GetComponent<PlayerController>().alive = false;
        pauseButton.SetActive(false);
        menuButton.SetActive(true);
        continueButton.SetActive(true);
    }

    public void Continue()
    {
        cam.GetComponent<PipesController>().speed = tempPipeSpeed;
        player.GetComponent<Rigidbody2D>().gravityScale = tempGrav;
        player.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, tempVelocity);
        player.GetComponent<PlayerController>().alive = true;
        pauseButton.SetActive(true);
        menuButton.SetActive(false);
        continueButton.SetActive(false);
    }
}
