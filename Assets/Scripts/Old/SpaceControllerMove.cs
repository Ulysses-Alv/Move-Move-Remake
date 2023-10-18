using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceControllerMove : MonoBehaviour {
    private Rigidbody2D RB;
    public float speed = -20f;


    // Use this for initialization
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        RB.velocity = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update() {
       if(transform.position.y < -12f)
       {
            Destroy(gameObject);
       }
    }

}
