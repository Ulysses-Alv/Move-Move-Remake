using System;
using UnityEngine;

public abstract class PowerUp : SpawneableObject
{
    protected override void AddForce()
    {
        float speed = GameDifficultyManager.instance.GetPowerUpSpeed();

        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed), ForceMode2D.Force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PowerUpLogic(collision);
    }

    protected abstract void PowerUpLogic(Collider2D collision);
}
