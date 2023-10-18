using UnityEngine;
using System;

[CreateAssetMenu(menuName = "Config/Enemy Configuration")]

public class EnemySpawnConfiguration : ScriptableObject
{
    [Range(1,30f)]
    public int repetitions;

    [Range(0.01f, 40f)]
    public float timeBetweenSpawn;

    [Range(0, 5)]
    public int spawnCount;

    [Range(0, 15)]
    public int preloadAmount;

    public GameObject prefab;

    public int orden;
}
