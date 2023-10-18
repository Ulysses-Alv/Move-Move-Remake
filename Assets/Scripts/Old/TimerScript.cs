using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
    [Tooltip("Escala Del Tiempo Del Timer")]
    [Range(0.0f, 10.0f)]
    float EscalaDelTiempo = 1f;

    public Text TusPuntos;

    private Text myText;
    private float tiempoDelFrameConTimeScale;
    private float tiempoAMostrarEnSegundos;
    private float escalaDeTiempoInicial; //escalaATiempoAlPausar, 
    //private bool estaPausado = false;

    // Start is called before the first frame update
    void Start()
    {
        escalaDeTiempoInicial = EscalaDelTiempo;
        myText = GetComponent<Text>();
        //tiempoAMostrarEnSegundos = tiempoInicial;
        //ActualizarTimer(tiempoInicial);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetFloat("Termino") == 1)
        {
            EscalaDelTiempo = 0f;
        }

        if (GameObject.FindGameObjectWithTag("Player") != null)
        {
            tiempoDelFrameConTimeScale = Time.deltaTime * EscalaDelTiempo;
            tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;
            ActualizarTimer(tiempoAMostrarEnSegundos + PlayerPrefs.GetFloat("Roze") * 3f);
        }
        

        // SISTEMA DE PUNTAJES
        if (GameObject.Find("Canvas-Barra") == null && GameObject.FindGameObjectWithTag("Player") == null)
        {
            var PuntajesCortados = (int)(tiempoAMostrarEnSegundos);
            var PuntajesDos = PuntajesCortados; //+ PlayerPrefs.GetFloat("Roze") * 3f

            TusPuntos.text = PuntajesDos.ToString();

            if (PuntajesDos> PlayerPrefs.GetFloat("PuntosActuales"))
            {
                PlayerPrefs.SetFloat("Puntaje", PuntajesDos);
                PlayerPrefs.SetFloat("PuntajeNeto", 1);
            }
            else PlayerPrefs.SetFloat("PuntajeNeto", 0);

        }
    }

    public void ActualizarTimer(float tiempoEnSegundos)
    {
        int minutos = 0;
        int segundos = 0;
        int milisegundos = 0;
        string textoDelReloj;
            if (tiempoEnSegundos < 0)
            {
                tiempoEnSegundos = 0;
            }
        minutos = (int)tiempoEnSegundos / 60;
        segundos = (int)tiempoEnSegundos % 60;
        milisegundos = (int)((tiempoEnSegundos * 1000) % 1000);
        textoDelReloj = minutos.ToString("00") + ":" + segundos.ToString("00");
        textoDelReloj += ".<size=" + myText.fontSize / 2 + ">" + milisegundos.ToString("000") + "</size>";
        myText.text = textoDelReloj;

    }
}
