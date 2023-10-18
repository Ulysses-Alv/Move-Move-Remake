using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fire_Generator : MonoBehaviour {
    public GameObject fire;
    //public float TiempoDeEspera = 0f;
    //float TiempoDeRepeticion = 2f;
 
  /* public float EscalaDelTiempo = 1f;
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
        Scene currentScene = SceneManager.GetActiveScene();
        string sceneName = currentScene.name;

        if (sceneName != "Nivel-1")
        {
            InvokeRepeating("GeneradorDeFireTres", Random.Range(4f, 6f), 1.2f);
            InvokeRepeating("GeneradorDeFireDos", 30f, 1.4f);
            InvokeRepeating("GeneradorDeFire", 60f, 1.7f);
            print("SI FUNCIONA JAJAJA SALU3");
        }
        else
        {
            InvokeRepeating("GeneradorDeFireTres", Random.Range(9f, 16f), 3f);
            print("NO FUNCIONA JAJAJA SALU3");
        }

    }

    void GeneradorDeFire()
    {
        CancelInvoke("GeneradorDeFireDos");
        //Busca el GameObject Fire que esta fuera de camara pero se mueve hasta desaparecer 
        
        //Para dar un pequeño tiempo de espera entre que entras y empezas a jugar

        var selectedFire = GameObject.Find("Fire");
        
        //El empty GameObj que a partir de ahi se genera el Fire

        var FireGenerator = GameObject.Find("Fire_Generator");
        
        //Al no haber un fire porque selectedFire dio null genera el Fire

        if (selectedFire == null)
        {

            float aleatorioUno = Random.Range(-10f, 15f);
            float aleatorioDos= Random.Range(-10f, 15f);
            float numeroNuevo = aleatorioUno + Random.Range(-1f, 6f);

            Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * aleatorioUno + Vector3.left * 1f;
            Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.up * numeroNuevo + Vector3.right * 1f;
            Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.up * numeroNuevo + Vector3.left * 2f;
            Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * aleatorioDos + Vector3.right * 2f;

            Instantiate(fire, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
            Instantiate(fire, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio
            Instantiate(fire, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
            Instantiate(fire, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
            Instantiate(fire, FireGenerator.transform.position, Quaternion.identity); //este es el Central

            print("spawnean 5");
        }

    }

    void GeneradorDeFireTres()
    {
        //Busca el GameObject Fire que esta fuera de camara pero se mueve hasta desaparecer 

        //Para dar un pequeño tiempo de espera entre que entras y empezas a jugar

        var selectedFire = GameObject.Find("Fire");

        //El empty GameObj que a partir de ahi se genera el Fire

        var FireGenerator = GameObject.Find("Fire_Generator");

        //Al no haber un fire porque selectedFire dio null genera el Fire

        if (selectedFire == null)
        {

            float aleatorioUno = Random.Range(-10f, 15f);
            float aleatorioDos = Random.Range(-10f, 15f);
            float numeroNuevo = aleatorioUno + Random.Range(-1f, 6f);

            /*Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * aleatorioUno + Vector3.left * 1f;
            Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.up * numeroNuevo + Vector3.right * 1f;*/

            Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.up * numeroNuevo + Vector3.left * Random.Range(1, 3);
            Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * aleatorioDos + Vector3.right * Random.Range(1, 3);

            /*Instantiate(fire, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
            Instantiate(fire, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio*/

            Instantiate(fire, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
            Instantiate(fire, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
            Instantiate(fire, FireGenerator.transform.position, Quaternion.identity); //este es el Central
            print("spawnean 3");
        }
    }

    void GeneradorDeFireDos()
    {
        CancelInvoke("GeneradorDeFireTres");
        
        //Busca el GameObject Fire que esta fuera de camara pero se mueve hasta desaparecer 

        //Para dar un pequeño tiempo de espera entre que entras y empezas a jugar

        var selectedFire = GameObject.Find("Fire");

        //El empty GameObj que a partir de ahi se genera el Fire

        var FireGenerator = GameObject.Find("Fire_Generator");

        //Al no haber un fire porque selectedFire dio null genera el Fire

        if (selectedFire == null)
        {

            float aleatorioUno = Random.Range(-10f, 15f);
            float aleatorioDos = Random.Range(-10f, 15f);
            float numeroNuevo = aleatorioUno + Random.Range(-1f, 6f);

            Vector3 GenerIzqUno = FireGenerator.transform.position + Vector3.up * aleatorioUno + Vector3.left * 1f;
            Vector3 GenerDerUno = FireGenerator.transform.position + Vector3.up * numeroNuevo + Vector3.right * 1f;
            Vector3 GenerIzqDos = FireGenerator.transform.position + Vector3.up * numeroNuevo + Vector3.left * Random.Range(0, 3);
            Vector3 GenerDerDos = FireGenerator.transform.position + Vector3.up * aleatorioDos + Vector3.right * Random.Range(0, 3);

            Instantiate(fire, GenerIzqUno, Quaternion.identity); //Esta es la linea Primera de la Izq contando desde el medio
            Instantiate(fire, GenerDerUno, Quaternion.identity); //Esta es la linea Primera de la Der contando desde el medio
            Instantiate(fire, GenerIzqDos, Quaternion.identity); //Esta es la linea Segunda de la Izq contando desde el medio
            Instantiate(fire, GenerDerDos, Quaternion.identity); //Esta es la linea Segunda de la Der contando desde el medio
            //Instantiate(fire, FireGenerator.transform.position, Quaternion.identity); //este es el Central
        }
        print("spawnean 4");
    }

    void Update()
    {
        if(GameObject.FindGameObjectWithTag("Player") == null)
        {
            Destroy(this.gameObject);
        }
    }
}
