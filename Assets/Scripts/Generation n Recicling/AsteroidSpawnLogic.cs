using System;
using UnityEngine;
using Random = UnityEngine.Random;

[Serializable]
public class AsteroidSpawnLogic : EnemySpawnLogic
{
    public override void SpawnEnemy(int Amount, GameObject prefab)
    {
        int position = -2;

        for (int i = 0; i < Amount; i++)
        {
            float YPosition = Random.Range(0, 10f);
            GameObject go = ObjectPooling.GetObject(prefab);
            go.transform.position = new Vector3(position, transform.position.y + YPosition, transform.position.z);
            position++;
        }
    }
}
