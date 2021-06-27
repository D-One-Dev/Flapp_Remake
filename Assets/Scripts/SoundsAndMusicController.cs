using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundsAndMusicController : MonoBehaviour
{
    [SerializeField] private AudioSource sounds, music;
    void Start()
    {
        sounds.volume = PlayerPrefs.GetFloat("Volume");
        music.volume = PlayerPrefs.GetFloat("Volume");
    }
}