using System.Linq;
using UniRx;
using UnityEngine;

public class EnemiesSpawnerManager : MonoBehaviour
{
    [SerializeField] private EnemiesSpawner[] enemiesSpawners;
    private int currentIndex = 0;
    [SerializeField] private SpawnerTimer spawnerTimer;

    private void Start()
    {
        ArrayOrderer();
        spawnerTimer.genCount.Subscribe(SpawnEnemy);
    }

    private void ArrayOrderer()
    {
        enemiesSpawners = enemiesSpawners.OrderByDescending(spawner => spawner.configuration.orden).ToArray();
        RestartTimer();

    }
    private void SpawnEnemy(int currentTime)
    {
        if (currentTime == 0) return;
        if (enemiesSpawners[currentIndex].configuration.repetitions < currentTime)
        {
            currentIndex++;
            if (currentIndex > enemiesSpawners.Length) currentIndex = 0;

            RestartTimer();
        }
        enemiesSpawners[currentIndex].SpawnObjects();
    }

    private void RestartTimer()
    {
        spawnerTimer.RestartTimer(enemiesSpawners[currentIndex].configuration.timeBetweenSpawn);
    }
}