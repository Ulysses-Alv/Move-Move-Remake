using System;
using UnityEngine;

public class EnemiesSpawner : MonoBehaviour, ISpawnObject
{
    [SerializeField] private EnemySpawnConfiguration spawnConfig;
    public EnemySpawnConfiguration configuration => spawnConfig;

    private EnemySpawnLogic logic;

    private void Start()
    {
        logic = GetComponent<EnemySpawnLogic>();

        ObjectPooling.PreLoad(spawnConfig.prefab, spawnConfig.preloadAmount);
    }
    public void SpawnObjects()
    {
        logic.SpawnEnemy(spawnConfig.spawnCount, spawnConfig.prefab);
    }
}
