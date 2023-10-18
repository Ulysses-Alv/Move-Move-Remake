using UnityEngine;

public class GameDifficultyManager : MonoBehaviour
{
    public static GameDifficultyManager instance;

    [SerializeField] private AnimationCurve spawneableObjSpeedCurve;

    private void Awake()
    {
        instance = this;
    }

    public float GetAsteroidSpeed()
    {
        float speed = spawneableObjSpeedCurve.Evaluate(GameTimerManager.instance.time) * 10;
        speed = Random.Range(speed - 50, speed + 50);
        
        return speed;
    }

    public float GetPowerUpSpeed()
    {
        return spawneableObjSpeedCurve.Evaluate(GameTimerManager.instance.time) * 10;
    }
}
