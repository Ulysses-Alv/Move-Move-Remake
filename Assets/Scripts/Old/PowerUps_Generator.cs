using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps_Generator : MonoBehaviour
{
    public GameObject PowerUps;
    public GameObject Escudo;
    float TiempoDeEspera;
    float TiempoDeRepeticion;

    void Start()
    {
        TiempoDeEspera = Random.Range(30f,45f);
        TiempoDeRepeticion = Random.Range(20f, 26f);

        //InvokeRepeating("GeneradorDePowerUp", TiempoDeEspera, TiempoDeRepeticion);
        InvokeRepeating("GeneradorDeEscudo", TiempoDeEspera, TiempoDeRepeticion);

    }

    void GeneradorDePowerUp()
    {
        var selectedPowerUp = GameObject.Find("Inmunidad");
        //El empty GameObj que a partir de ahi se genera el Fire
        var PowerUpGenerator = GameObject.Find("PowerUps_Generator");
        //Al no haber un fire porque selectedFire dio null genera el Fire

        if (selectedPowerUp == null)
        {
            Vector3 PowerUp1= PowerUpGenerator.transform.position + Vector3.right * Random.Range(-2, 3);
            Instantiate(PowerUps, PowerUp1, Quaternion.identity); //Genera el Power Up de inmunidad

        }
    }

    void GeneradorDeEscudo()
    {

        var PowerUpGenerator = GameObject.Find("PowerUps_Generator");

        Vector3 PowerUp1 = PowerUpGenerator.transform.position + Vector3.right * Random.Range(-2, 3);
        Instantiate(Escudo, PowerUp1, Quaternion.identity); //Genera el Power Up de inmunidad
    }

    void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            Destroy(this.gameObject);
        }
    }

}

//Vector3 Generador2 = FireGenerator.transform.position + Vector3.down * Random.Range(-11.0f, 10.0f) + Vector3.right * 1f;
//Vector3 Generador3 = FireGenerator.transform.position + Vector3.down * Random.Range(-11.0f, 10.0f) + Vector3.left * 2f;
//Vector3 Generador4 = FireGenerator.transform.position + Vector3.up * Random.Range(-11.0f, 10.0f) + Vector3.right * 2f;
//Instantiate(PowerUps, Generador2, Quaternion.identity); 
//Instantiate(fire, Generador3, Quaternion.identity);
//Instantiate(fire, Generador4, Quaternion.identity); 
//Instantiate(fire, FireGenerator.transform.position, Quaternion.identity);

