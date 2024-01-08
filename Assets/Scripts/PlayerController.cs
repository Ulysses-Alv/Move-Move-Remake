using System;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;

    [Range(0.001f, 1f)]
    [SerializeField] private float speed;

    [SerializeField] private bool isInmune;

    private Rigidbody2D rb;

    private void Awake()
    {
        instance = this;
        rb = GetComponent<Rigidbody2D>();
    }

    public void Move(Vector2 inputMovement)
    {
        rb.AddForce(new Vector3(inputMovement.x, 0, 0) * speed, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Asteroid")) return;

        if (ShieldController.instance.isShieldActive)
        {
            ShieldController.instance.DamageShield();
            return;
        }

        if (!isInmune)
        {
            LifeController.instance.ReduceLife();
        }
        EnemyRecicler.instance.RecicleGO(collision.gameObject);
    }
}