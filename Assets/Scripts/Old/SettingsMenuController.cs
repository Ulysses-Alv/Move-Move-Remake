using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsMenuController : MonoBehaviour
{
    private Rigidbody2D RB;
    public float Y = 2f;
    public float X = -20f;

    public void MenuDeslizante()
    {
        RB = GetComponentInChildren<Rigidbody2D>();
        RB.velocity = new Vector3(X, Y, 0);  
    }

    public void ReturnRight()
    {
        if(transform.position.x <= 0)
        {
            RB.velocity = new Vector3(20f, Y, 0);
        }
    }

    public void ReturnLeft()
    {
        if (transform.position.x >= 0)
        {
            RB.velocity = new Vector3(-20f, Y, 0);
        }
    }

    public void ReturnDown()
    {
        if (transform.position.y >= 0)
        {
            RB.velocity = new Vector3(X, -20f, 0);
        }
    }
}
