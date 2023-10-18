using UnityEngine;

public class ShieldPowerUp : PowerUp
{
    protected override void PowerUpLogic(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ShieldController.instance.TurnOnShield();
            PowerUpRecicler.instance.RecicleGO(gameObject);
        }
        else if (collision.CompareTag("Asteroid"))
        {
            EnemyRecicler.instance.RecicleGO(collision.gameObject);
        }
    }
}
