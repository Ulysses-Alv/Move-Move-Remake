using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Robot_Controller : MonoBehaviour
{
    GameObject player;

    GameObject pos0;
    GameObject pos1;
    GameObject pos2;
    GameObject pos3;
    GameObject pos4;

    Rigidbody2D Rigidbody;

    public float vel1;

    float Aleatorio;

    float posicion;
    float arte;
    bool uno = false;

    Vector3 target;

    // StartGame is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Aleatorio = Random.Range(0, 6);
        print(Aleatorio);

        
        pos0 = GameObject.Find("Objetivo0");
        pos1 = GameObject.Find("Objetivo1");
        pos2 = GameObject.Find("Objetivo2");
        pos3 = GameObject.Find("Objetivo-1");
        pos4 = GameObject.Find("Objetivo-2");

        if(Aleatorio == 5f)
        {
            Invoke("Cancelar", 2.2f);

        }
        
    }

    void Cancelar()
    {
        uno = true;
        print("CANCELADO");
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Aleatorio >= 0 && Aleatorio <= 4)
        {
                Rigidbody = GetComponent<Rigidbody2D>();
                Rigidbody.velocity = new Vector3(0, vel1, 0);
        }
        if (Aleatorio == 0 && this.transform.position.y < 1f)
        {
            target = pos0.transform.position;
            float fixedspeed = vel1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, fixedspeed * -3);
            Debug.DrawLine(transform.position, target, Color.cyan);
        }

        if (Aleatorio == 1 && this.transform.position.y < 1f)
        {
            target = pos1.transform.position;
            float fixedspeed = vel1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, fixedspeed * -3);
            Debug.DrawLine(transform.position, target, Color.cyan);
        }

        if (Aleatorio == 2 && this.transform.position.y < 1f)
        {
            target = pos2.transform.position;
            float fixedspeed = vel1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, fixedspeed * -3);
            Debug.DrawLine(transform.position, target, Color.cyan);
        }

        if (Aleatorio == 3 && this.transform.position.y < 1f)
        {
            target = pos3.transform.position;
            float fixedspeed = vel1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, fixedspeed * -3);
            Debug.DrawLine(transform.position, target, Color.cyan);
        }

        if (Aleatorio == 4 && this.transform.position.y < 1f)
        {
            target = pos4.transform.position;
            float fixedspeed = vel1 * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, target, fixedspeed * -3);
            Debug.DrawLine(transform.position, target, Color.cyan);
        }

        if (Aleatorio == 5f)
        {
            if(uno == false)
            {
                posicion = player.transform.position.x - this.transform.position.x;
                Rigidbody = GetComponent<Rigidbody2D>();
                Rigidbody.velocity = new Vector3(posicion, vel1, 0);
            }
            if (uno == true)
            {
                posicion = player.transform.position.x - this.transform.position.x;
                Rigidbody = GetComponent<Rigidbody2D>();
                Rigidbody.velocity = new Vector3(posicion, vel1 - 1.5f, 0);
            }
        }

        if (PlayerPrefs.GetFloat("Termino") == 1)
        {
            Destroy(gameObject);
        }

        if (transform.position.y < -5.5f)
        {
            Destroy(gameObject);
        }
        
        float newX = Mathf.Clamp(transform.position.x, -3 + 1, 3 - 1);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }
}






/*if (Aleatorio == 2f)
       {
           var posicion = player.transform.position.x - this.transform.position.x;
           Rigidbody = GetComponent<Rigidbody2D>();
           Rigidbody.velocity = new Vector3(posicion, vel1, 0);
       }

       if (Aleatorio == 1f)
       {

           Rigidbody = GetComponent<Rigidbody2D>();
           Rigidbody.velocity = new Vector3(randon, vel1, 0);
           uno = true;
       }

       if (uno == false)
       {
           Rigidbody = GetComponent<Rigidbody2D>();
           Rigidbody.velocity = new Vector3(0, vel1, 0);
       }*/
