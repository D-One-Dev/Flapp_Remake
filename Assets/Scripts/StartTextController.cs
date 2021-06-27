using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartTextController : MonoBehaviour
{
    [SerializeField] private Text startTxt;
    [SerializeField] private Outline ol;
    private float alpha;
    void FixedUpdate()
    {
        alpha = Mathf.PingPong(Time.time / 1.5f, 1f);
        startTxt.color = new Color(startTxt.color.r, startTxt.color.g, startTxt.color.b, alpha);
        ol.effectColor = new Color(ol.effectColor.r, ol.effectColor.g, ol.effectColor.b, alpha);
    }
}
