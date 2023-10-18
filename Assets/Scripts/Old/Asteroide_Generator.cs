using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroide_Generator : MonoBehaviour { 
    public GameObject objeto;

    /*public float TiempoDeEspera = 0f;
float TiempoDeRepeticion = 2f;

 public float EscalaDelTiempo = 1f;
  private float tiempoDelFrameConTimeScale = 0f;
  private float tiempoAMostrarEnSegundos = 0f;

  void Update()
  {
     tiempoDelFrameConTimeScale = Time.deltaTime * EscalaDelTiempo;
     tiempoAMostrarEnSegundos += tiempoDelFrameConTimeScale;

     if(tiempoAMostrarEnSegundos > 10f && TiempoDeRepeticion != 0f)
     {
          tiempoAMostrarEnSegundos = tiempoAMostrarEnSegundos - 10f;
          TiempoDeRepeticion = TiempoDeRepeticion - 3f;
          Debug.Log(TiempoDeRepeticion);
     }
  }*/

    void Start()
{
    InvokeRepeating("GeneradorDeFire", 4.5f, 1.7f);

}

    void GeneradorDeFire()
{
    //Busca el GameObject Fire que esta fuera de camara pero se mueve hasta desaparecer 
    //Para dar un pequeño tiempo de espera entre que entras y empezas a jugar
    var selectedFire = GameObject.Find("Asteroide");
    //El empty GameObj que a partir de ahi se genera el Fire
    var FireGenerator = GameObject.Find("Fire_Generator");
    //Al no haber un fire porque selectedFire dio null genera el Fire
    if (selectedFire == null)
    {
        Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * Random.Range(-11, 11) + Vector3.left * 1f;
        Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.down * Random.Range(-11, 11) + Vector3.right * 1f;
        Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.down * Random.Range(-11, 11) + Vector3.left * 2f;
        Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * Random.Range(-11, 11) + Vector3.right * 2f;

        Instantiate(objeto, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
        Instantiate(objeto, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio
        Instantiate(objeto, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
        Instantiate(objeto, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
        Instantiate(objeto, FireGenerator.transform.position, Quaternion.identity); //este es el Central
    }
}
}