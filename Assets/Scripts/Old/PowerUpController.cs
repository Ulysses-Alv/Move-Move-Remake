using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpController: MonoBehaviour
{
    private Rigidbody2D RBpowerUp;
    float velocidad = -9f;

    // Use this for initialization

    void OnTriggerEnter2D(Collider2D objeto)
    {
        if (this.gameObject.tag == "Inmunidad" || this.gameObject.tag == "PowerUpEscudo" && objeto.gameObject.tag == "Fire")
        {
            Destroy(objeto);
            //print("Destrozado");
        }
        
        /* if (this.gameObject.tag == "Inmunidad" || this.gameObject.tag == "Disparos" && objeto.gameObject.tag == "Asteroide")
         {
             Destroy(objeto);
             print("Destrozado");
         }
         if (this.gameObject.tag == "Inmunidad" || this.gameObject.tag == "Disparos" && objeto.gameObject.tag == "AsteroideGrande")
         {
             print("Destrozado");
             Destroy(objeto);
         }
         if (this.gameObject.tag == "Inmunidad" || this.gameObject.tag == "Disparos" && objeto.gameObject.tag == "Robot")
         {
             print("Destrozado");
             Destroy(objeto);
         }*/

        if (this.gameObject.tag == objeto.gameObject.tag)
        {
            Destroy(objeto);
            Destroy(gameObject);
            print("Destrozado");
        }
    }

    void Start()
    {
            RBpowerUp = GetComponent<Rigidbody2D>();
            RBpowerUp.velocity = new Vector3(0, velocidad, 0);
        
        
    }

    // Update is called once per frame
    void Update()
    {
       
         if (transform.position.y < -10f)
        {
            Destroy(gameObject);
        }
        


    }

}
