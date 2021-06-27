using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource audSource;
    [SerializeField] private Sprite muted, unmuted;
    [SerializeField] private GameObject muteButton;
    private int enable;
    void Start()
    {
        audSource.volume = PlayerPrefs.GetFloat("Volume");
        enable = PlayerPrefs.GetInt("VolumeEnable");
        switch (enable)
        {
            case 1:
                muteButton.GetComponent<Image>().sprite = unmuted;
                break;
            case 0:
                muteButton.GetComponent<Image>().sprite = muted;
                break;
            default:
                break;
        }
    }
    void Update()
    {
    }
    public void ChangeVolume()
    {
        switch (enable)
        {
            case 1:
                enable = 0;
                PlayerPrefs.SetInt("VolumeEnable", 0);
                PlayerPrefs.SetFloat("Volume", 0f);
                audSource.volume = 0f;
                muteButton.GetComponent<Image>().sprite = muted;
                break;
            case 0:
                enable = 1;
                PlayerPrefs.SetInt("VolumeEnable", 1);
                PlayerPrefs.SetFloat("Volume", 1f);
                audSource.volume = 1f;
                muteButton.GetComponent<Image>().sprite = unmuted;
                break;
        }
    }
}
