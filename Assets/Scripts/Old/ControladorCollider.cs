using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCollider : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D objeto)
    {
        /*if(objeto.gameObject.tag != "Player" || objeto.gameObject.tag != "Fondo" || objeto.gameObject.tag != "Escudo")
        {
            Destroy(objeto);
        }*/
        
    }
}
