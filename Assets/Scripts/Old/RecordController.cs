using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RecordController : MonoBehaviour
{
    public Text RecordText;

    public Animator btnuno;
    public Animator btndos;

    public Color amarillo;
    public Color gris;

    string Segundo = "Pts.";


    void Start()
    {
        RecordText.text = PlayerPrefs.GetFloat("PuntosActuales").ToString() + "<size=" + RecordText.fontSize / 1.5f + ">" + Segundo + "</size>";
        //RecordText.color = amarillo;
    }

    public float GetMaxScore()
    {
        return PlayerPrefs.GetFloat("Puntaje", 0);
    }

    void Update()
    {
        if (PlayerPrefs.GetFloat("Puntaje") > PlayerPrefs.GetFloat("PuntosActuales", 0))
        {
            string Tiempo;

            PlayerPrefs.SetFloat("PuntosActuales", PlayerPrefs.GetFloat("Puntaje"));

            Tiempo = PlayerPrefs.GetFloat("PuntosActuales").ToString();
            Tiempo += "<size=" + RecordText.fontSize / 2 + ">" + Segundo + "</size>";

            RecordText.text = Tiempo;
          //  RecordText.color = amarillo;

        }

        if (PlayerPrefs.GetFloat("PuntosActuales") == 0)
        {
            RecordText.text = "---";
            RecordText.color = gris;
            btndos.SetBool("PrimeraVez", true);
            btnuno.SetBool("PrimeraVez", true);
        }
    }
}
