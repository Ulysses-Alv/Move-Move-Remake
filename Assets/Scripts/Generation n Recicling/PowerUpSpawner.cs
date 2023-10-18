using UnityEngine;
using Random = UnityEngine.Random;
using UniRx;

public class PowerUpSpawner : MonoBehaviour
{
    [SerializeField] private SpawnerTimer spawnerTimer;
    [SerializeField] private GameObject Shield;
    [SerializeField] private GameObject ExtraLife;

    private void Start()
    {
        PreloadSpawneableObjects();
        spawnerTimer.genCount.Subscribe(SpawnPowerUp);
    }
    private void PreloadSpawneableObjects()
    {
        ObjectPooling.PreLoad(Shield, 1);
        ObjectPooling.PreLoad(ExtraLife, 1);
    }

    private void SpawnPowerUp(int secondsOfSpawn)
    {
        if (secondsOfSpawn == 0) return;

        GameObject powerUp = ObjectPooling.GetObject(GetRandomPowerUp());

        powerUp.transform.position =
            new Vector3(GetRandomPosition(), transform.position.y + 2f, transform.position.z);
    }

    private GameObject GetRandomPowerUp()
    {
        GameObject[] prefabs = new GameObject[] { Shield, ExtraLife };

        return prefabs[Random.Range(0, prefabs.Length)];
    }

    private float GetRandomPosition()
    {
        float[] xPosition = new float[] { -2, -1, 0, 1, 2 };

        return xPosition[Random.Range(0, xPosition.Length)];
    }
}