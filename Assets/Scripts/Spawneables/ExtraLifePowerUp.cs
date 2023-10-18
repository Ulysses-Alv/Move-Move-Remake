using UnityEngine;

public class ExtraLifePowerUp : PowerUp
{
    protected override void PowerUpLogic(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            LifeController.instance.GiveLife();
            PowerUpRecicler.instance.RecicleGO(gameObject);
        }
        else if (collision.CompareTag("Asteroid"))
        {
            EnemyRecicler.instance.RecicleGO(collision.gameObject);
        }
    }
}