using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Generator : MonoBehaviour
{
    public GameObject Robot;

    void Start()
    {
        InvokeRepeating("Generador15seg", 5f, 3f);
        InvokeRepeating("Generador30seg", 20f, 3.5f);
        InvokeRepeating("Generador45seg", 35f, 4f);
        InvokeRepeating("Generador60seg", 50f, 4.5f);
    }

    void Generador15seg()
    {
        var selectedFire = GameObject.Find("Robot");
        var FireGenerator = GameObject.Find("Fire_Generator");

        if (selectedFire == null)
        {
            Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * 1f + Vector3.left * 1f;
            Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.up * 2f + Vector3.right * 1f;

            Instantiate(Robot, FireGenerator.transform.position, Quaternion.identity); //este es el Central
            Instantiate(Robot, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
            Instantiate(Robot, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio
        }
    }

    void Generador30seg()
    {
        CancelInvoke("Generador15seg");
        var selectedFire = GameObject.Find("Robot");
        var FireGenerator = GameObject.Find("Fire_Generator");
        if (selectedFire == null)
        {
           
            Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.up * 1f + Vector3.left * 2f;
            Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * 2f + Vector3.right * 2f;

            Instantiate(Robot, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
            Instantiate(Robot, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
            Instantiate(Robot, FireGenerator.transform.position, Quaternion.identity); //este es el Central
        }
    }

    void Generador45seg()
    {
        CancelInvoke("Generador30seg");
        var selectedFire = GameObject.Find("Robot");
        var FireGenerator = GameObject.Find("Fire_Generator");

        if (selectedFire == null)
        {
            Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * 1.5f + Vector3.left * 1f;
            Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.up * 2f + Vector3.right * 1f;
            Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.up * 3f + Vector3.left * 3f;
            Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * 4f + Vector3.right * 3f;

            Instantiate(Robot, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
            Instantiate(Robot, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio
            Instantiate(Robot, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
            Instantiate(Robot, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
            Instantiate(Robot, FireGenerator.transform.position, Quaternion.identity); //este es el Central
        }
    }

    void Generador60seg()
    {
        CancelInvoke("Generador45seg");
        var selectedFire = GameObject.Find("Robot");
        var FireGenerator = GameObject.Find("Fire_Generator");

        if (selectedFire == null)
        {
            Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * Random.Range(-11, 11) + Vector3.left * 1f;
            Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.down * Random.Range(-11, 11) + Vector3.right * 1f;
            Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.down * Random.Range(-11, 11) + Vector3.left * 2f;
            Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * Random.Range(-11, 11) + Vector3.right * 2f;

            Instantiate(Robot, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
            Instantiate(Robot, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio
            Instantiate(Robot, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
            Instantiate(Robot, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
            Instantiate(Robot, FireGenerator.transform.position, Quaternion.identity); //este es el Central
        }
    }

}