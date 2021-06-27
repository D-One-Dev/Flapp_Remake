using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private AudioSource audSource;
    [SerializeField] private AudioClip jumpSound, deathSound;
    [SerializeField] private GameObject restartButton, menuButton, pauseButton;
    [SerializeField] private SpriteRenderer sr;
    [SerializeField] private Sprite birdJump, birdFall;
    [SerializeField] private Text TempScore, endScore, highScore, scoreTxt, hScoreTxt;
    [SerializeField] private GameObject cam, canvas;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce;
    public bool alive = true;
    void FixedUpdate()
    {
        if (rb.velocity.y > 0f) sr.sprite = birdJump;
        else sr.sprite = birdFall;
    }

    public void Jump()
    {
        if (alive)
        { 
            rb.velocity = new Vector2(0f, jumpForce);
            audSource.clip = jumpSound;
            audSource.Play();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            if (canvas.GetComponent<ScoreController>().score > PlayerPrefs.GetInt("Highscore"))
                PlayerPrefs.SetInt("Highscore", canvas.GetComponent<ScoreController>().score); 
            alive = false;
            menuButton.SetActive(true);
            restartButton.SetActive(true);
            pauseButton.SetActive(false);
            highScore.text = PlayerPrefs.GetInt("Highscore").ToString();
            highScore.enabled = true;
            endScore.text = canvas.GetComponent<ScoreController>().score.ToString();
            endScore.enabled = true;
            TempScore.enabled = false;
            scoreTxt.enabled = true;
            hScoreTxt.enabled = true;
            rb.gravityScale = 0f;
            rb.velocity = Vector2.zero;
            cam.GetComponent<PipesController>().speed = 0f;
            audSource.clip = deathSound;
            audSource.Play();
        }
    }
}
