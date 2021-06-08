using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private GameObject player, cam, pipes1, pipes2;
    [SerializeField] private Text scoreTxt;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (pipes1.transform.position.x < player.transform.position.x && cam.GetComponent<PipesController>().pipes1Passed != true)
        {
            score++;
            cam.GetComponent<PipesController>().pipes1Passed = true;
            scoreTxt.text = score.ToString();
        }

        if (pipes2.transform.position.x < player.transform.position.x && cam.GetComponent<PipesController>().pipes2Passed != true)
        {
            score++;
            cam.GetComponent<PipesController>().pipes2Passed = true;
            scoreTxt.text = score.ToString();
        }
    }
}
