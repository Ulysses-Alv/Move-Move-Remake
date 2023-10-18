using UnityEngine;

public class Asteroid : SpawneableObject
{
    [SerializeField] private Sprite[] sprites;

    protected override void AddForce()
    {
        GetComponent<SpriteRenderer>().sprite = sprites[Random.Range(0, sprites.Length)];
        float speed = GameDifficultyManager.instance.GetAsteroidSpeed();

        GetComponent<Rigidbody2D>().AddForce(new Vector2(0, -speed), ForceMode2D.Force);
    }
}
