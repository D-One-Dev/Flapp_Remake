using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
