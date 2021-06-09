using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Text Txt;
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

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        //{
            //Debug.Log(1);
            //Txt.text = "0";
        //}
    }

    private void Touch()
    {
        Debug.Log(1);
        Txt.text = "0";
    }
}
