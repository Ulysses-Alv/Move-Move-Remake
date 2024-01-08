using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetivos_Controlador : MonoBehaviour
{
    // StartGame is called before the first frame update
    void Start()
    {
        if(GameObject.Find("Nivel 1")) {
            Invoke("ObjetivoUno", 5f);
        }
        else
        {
            Invoke("ObjetivoDos", 5f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ObjetivoUno()
    {
        this.gameObject.SetActive(false);
    }

    void ObjetivoDos()
    {
        this.gameObject.SetActive(false);
    }
}
