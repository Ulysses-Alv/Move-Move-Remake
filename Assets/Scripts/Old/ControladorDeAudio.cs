using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;


public class ControladorDeAudio : MonoBehaviour
{
    public GameObject FuenteDeAudio;

    private void Update()
    {
        print(PlayerPrefs.GetFloat("MusicaOn"));
        if (PlayerPrefs.GetFloat("MusicaOn") == 1f)
        {
            FuenteDeAudio.gameObject.GetComponent<AudioSource>().mute = false;
            //FuenteDeAudio.gameObject.SetActive(true);
        }
        else
        {
            //FuenteDeAudio.gameObject.SetActive(false);
            FuenteDeAudio.gameObject.GetComponent<AudioSource>().mute = true;
        }
    }
    private void Awake()
    {
        FuenteDeAudio = GameObject.Find("Audio Source");
        
    }
}
