using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Text score, endScore;
    [SerializeField] private GameObject cam, canvas;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce;
    private Game pi;
    private void Awake()
    {
        pi = new Game();
        pi.Gameplay.Touch.performed += context => Touch();
    }
    private void OnEnable()
    { pi.Enable(); }
    private void OnDisable()
    { pi.Disable(); }
    void Start()
    {
        
    }
    void FixedUpdate()
    {
    }

    private void Touch()
    {
        rb.velocity = new Vector2(0f, jumpForce);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pipe"))
        {
            endScore.text = canvas.GetComponent<ScoreController>().score.ToString();
            endScore.enabled = true;
            score.enabled = false;
            rb.gravityScale = 0f;
            rb.velocity = Vector2.zero;
            cam.GetComponent<PipesController>().speed = 0f;
        }
    }
}
