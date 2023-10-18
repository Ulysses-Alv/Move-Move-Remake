using UnityEngine;
using System.Collections.Generic;
using System;

public class EnemyRecicler : Recicler
{
    [SerializeField] private GameObject AsteroidPrefab;
    [SerializeField] private GameObject LargeAsteroidPrefab;
    [SerializeField] private GameObject RobotPrefab;

    public static EnemyRecicler instance;
    private GameObject[] prefabs;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != null && instance != this)
        {
            Destroy(this);
        }
        prefabs = new GameObject[] { AsteroidPrefab, LargeAsteroidPrefab, RobotPrefab };

    }

    public override void RecicleGO(GameObject asteroid)
    {
        var id = asteroid.GetComponent<SpawneableObject>().Id;

        foreach (GameObject prefab in prefabs)
        {
            if (id != prefab.GetComponent<SpawneableObject>().Id) continue;

            ObjectPooling.RecicleObject(prefab, asteroid);
        }
    }

    protected override void OnTriggerAction(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("Asteroid")) return;

        RecicleGO(collision.gameObject);
    }
}