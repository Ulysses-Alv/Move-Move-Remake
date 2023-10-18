using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class MusicaAleatoria : MonoBehaviour
{
    public AudioClip Audio0;
    public AudioClip Audio1;
    public GameObject Navecita;

    int i;
    private void Awake()
    {
        i = Random.Range(1, 3);
        print("VALOR DE I = " + i);
        if (i == 1)
        {
            this.gameObject.GetComponent<AudioSource>().clip = Audio0;
            this.gameObject.GetComponent<AudioSource>().Play();
        }
        if (i == 2)
        {
            this.gameObject.GetComponent<AudioSource>().clip = Audio1;
            this.gameObject.GetComponent<AudioSource>().Play();
        }
    }
    private void Update()
    {
        if(Navecita == null)
        {
            this.gameObject.GetComponent<AudioSource>().Stop();
        }
    }
}
