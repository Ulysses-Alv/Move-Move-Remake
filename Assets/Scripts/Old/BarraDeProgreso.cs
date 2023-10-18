using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BarraDeProgreso : MonoBehaviour
{
    private float tiempoDelFrameConTimeScale = 0f;
    private float tiempoAMostrarEnSegundos = 0f;
    
    public float tiempo = 65f;
    public Image barra;
    public GameObject GeneradorDeFuego;
    public GameObject GeneradorDePowerUp;
    public GameObject texto;
    public GameObject BackMenu;
    public GameObject SigLevel;


    void Start()
    {
        texto.SetActive(false);
        SigLevel.gameObject.SetActive(false);
        PlayerPrefs.SetFloat("Termino", 0);       
    }

    // Update is called once per frame
    void Update()
    {
        tiempoDelFrameConTimeScale = Time.deltaTime * 1f;
        tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;
        
        var escala = tiempoAMostrarEnSegundos / tiempo;
        if(escala != 1 && escala <= 1)
        {
            barra.transform.localScale = new Vector2(escala, 1);
        }
        if(escala >= 1)
        {
            GeneradorDeFuego.SetActive(false);
            GeneradorDePowerUp.SetActive(false);
            texto.SetActive(true);
            BackMenu.gameObject.SetActive(true);
            SigLevel.SetActive(true);
            PlayerPrefs.SetFloat("Termino", 1);
            print("Uli");
        }
    }
}