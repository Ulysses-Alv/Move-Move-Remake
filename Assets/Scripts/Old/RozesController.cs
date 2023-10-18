using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RozesController : MonoBehaviour
{
    public Text Rozes;
    public GameObject RozesTotales;

    void Start()
    {
        RozesTotales.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Time.timeScale == 0)
        {
            RozesTotales.gameObject.SetActive(true);

            string Roze;

            Roze = "Rozes:" + PlayerPrefs.GetFloat("Roze", 0);

            Rozes.text = Roze;
        }
        print(PlayerPrefs.GetFloat("Roze") + "ROZES");
    }

    
}
