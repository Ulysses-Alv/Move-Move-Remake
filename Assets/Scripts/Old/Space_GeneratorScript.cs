using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Space_GeneratorScript : MonoBehaviour {

    public GameObject backgroud;
    public float Cantidad;
    
	void Start () {
        InvokeRepeating("GeneradorDeSpace", 0f, Cantidad);
    }

    void GeneradorDeSpace()
    {
        //busca la posicion de el background "space"
        var selectedBackground= GameObject.Find("Space");
        //El empty GameObj que a partir de ahi se genera el background
        var GameObjectEmptyGenerator = GameObject.Find("Background_Generator");
            //Al no haber un background porque Space dio null genera el background
            if (selectedBackground == null)
            {
            Vector3 Generador = GameObjectEmptyGenerator.transform.position; //+ Vector3.left * Random.Range(-1.0f, 1.0f);
                Instantiate(backgroud, Generador, Quaternion.identity);
            }
    }

    private void Update()
    {
        if (GameObject.FindGameObjectWithTag("Player") == null)
        {
            Destroy(this.gameObject);
        }
    }
}
