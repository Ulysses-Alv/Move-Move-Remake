using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderNumero : MonoBehaviour
{
    public float Numero = 0f;

    public Text texto;
    public GameObject slider;
    float Deslizador;

    void Start()
    {
        Deslizador = PlayerPrefs.GetFloat("Velocidad", 8);
        slider.gameObject.GetComponent<Slider>().value = Deslizador;
    }

    // Update is called once per frame
    void Update()
    {
        var text = Numero.ToString();
        texto.text = text;
    }

    public void CambiarNumero(float NewNumero)
    {
        Numero = NewNumero;
    }
}
