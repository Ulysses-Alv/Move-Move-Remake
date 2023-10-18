using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscudoController : MonoBehaviour
{
    public GameObject EscudoAl100;
    public GameObject EscudoAl66;
    public GameObject EscudoAl33;


    public float Recibidos = 0;

    void OnTriggerEnter2D(Collider2D objetoQueLoToca)
    {
        if (objetoQueLoToca.gameObject.tag == "Fire" && Recibidos == 2f)
        {
            objetoQueLoToca.gameObject.SetActive(false);
            EscudoAl33.gameObject.SetActive(false);
            Recibidos = 3f;
        }

        if (objetoQueLoToca.gameObject.tag == "Fire" && Recibidos == 1f)
        {
            objetoQueLoToca.gameObject.SetActive(false);
            EscudoAl66.gameObject.SetActive(false);
            EscudoAl33.gameObject.SetActive(true);
            Recibidos = 2f;
        }

        if (objetoQueLoToca.gameObject.tag == "Fire" && Recibidos == 0)
        {
            objetoQueLoToca.gameObject.SetActive(false);
            EscudoAl100.gameObject.SetActive(false);
            EscudoAl66.gameObject.SetActive(true);
            Recibidos = 1f;
            print("DAÑO");
        }
    }


    void Start()
    {
        EscudoAl100.gameObject.SetActive(true);
        //EscudoAl66.gameObject.SetActive(false);
        //EscudoAl33.gameObject.SetActive(false);
    }

    void Update()
    {
        if(Recibidos == 3f)
        {
            this.gameObject.SetActive(false);
        }    
        if(Recibidos == 0f && this.gameObject.activeSelf == true && this.gameObject.GetComponent("Capsule Collider 2D") != null)
        {
            EscudoAl100.gameObject.SetActive(true);
        }

    }
}
