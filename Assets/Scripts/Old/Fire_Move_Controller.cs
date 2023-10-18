using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire_Move_Controller : MonoBehaviour {
    private Rigidbody2D RB;

    public Sprite AsteroideA;
    public Sprite AsteroideB;
    public Sprite AsteroideC;
    public Sprite EnemigoA;
    public Sprite EnemigoB;
    public Sprite EnemigoC;

    public GameObject Llamas;
    public GameObject Llamas1;
    public GameObject Llamas2;

    float Aleatorio;
    float AleatorioLlamas;
    float velocidad;

    void OnTriggerEnter2D(Collider2D objetoQueLoToca)
    {
        if(objetoQueLoToca.gameObject.tag == "Escudo")
        {
            Destroy(gameObject);
        }
    }

    //public float speed;
    void Start()
    {
        Aleatorio = Random.Range(1, 4);
        AleatorioLlamas = Random.Range(1, 4);
        if (this.gameObject.tag == "Fire")
        {
            if(AleatorioLlamas == 1)
            {
                velocidad = -1 * Random.Range(7f, 9f); 
            }
            if (AleatorioLlamas == 2)
            {
                velocidad = -1 * Random.Range(5f, 7f);
            }
            if(AleatorioLlamas == 3)
            {
                velocidad = -1 * Random.Range(9f, 11f);
            }
            RB = GetComponent<Rigidbody2D>();
            RB.velocity = new Vector3(0, velocidad, 0);

        }
        if(this.gameObject.tag == "Asteroide")
        {
            RB = GetComponent<Rigidbody2D>();
            RB.velocity = new Vector3(0, -7f, 0);
            print("asteroide");
        }
        if (this.gameObject.tag == "AsteroideGrande")
        {
            RB = GetComponent<Rigidbody2D>();
            print("asteroidegrande");
            RB.velocity = new Vector3(0, -9f, 0);
        }
    }

    void Update()
    {
        if (transform.position.y < -9f)
        {
            Destroy(gameObject);
        }

        if (PlayerPrefs.GetFloat("Termino") == 1)
        {
            Destroy(gameObject);
        }


        if (Aleatorio == 1)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = AsteroideA;
        }
        if (Aleatorio == 2)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = AsteroideB;
        }
        if (Aleatorio == 3)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = AsteroideC;
        }
        if (Aleatorio == 4)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = EnemigoA;
            Llamas.gameObject.SetActive(false);
        }
        if (Aleatorio == 5)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = EnemigoB;
            Llamas.gameObject.SetActive(false);
        }
        if (Aleatorio == 6)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = EnemigoC;
            Llamas.gameObject.SetActive(false);
        }

        if(AleatorioLlamas == 1)
        {
            Llamas.gameObject.SetActive(true);
            Llamas1.gameObject.SetActive(false);
            Llamas2.gameObject.SetActive(false);
        }

        if (AleatorioLlamas == 2)
        {
            Llamas.gameObject.SetActive(false);
            Llamas1.gameObject.SetActive(true);
            Llamas2.gameObject.SetActive(false);
        }

        if (AleatorioLlamas == 3)
        {
            Llamas.gameObject.SetActive(false);
            Llamas1.gameObject.SetActive(false);
            Llamas2.gameObject.SetActive(true);
        }
    }

}