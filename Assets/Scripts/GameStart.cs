using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{
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
    void Update()
    {
        
    }
    private void Touch()
    {
        SceneManager.LoadScene("Game");
    }
}
