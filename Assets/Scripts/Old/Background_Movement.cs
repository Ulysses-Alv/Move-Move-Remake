using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background_Movement : MonoBehaviour
{
    private Rigidbody2D RB;
    public float velocidad = 0f;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = new Vector3(0, velocidad, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerPrefs.GetFloat("Termino") == 1f)
        {
            RB.velocity = new Vector3(0, 0, 0);
        }
        if(this.transform.position.y <= -40f)
        {
            Destroy(gameObject);
        }
    }
}
