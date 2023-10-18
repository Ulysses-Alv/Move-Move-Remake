using UnityEngine;
using Random = UnityEngine.Random;

public class LargeAsteroidSpawnLogic : EnemySpawnLogic
{
    public override void SpawnEnemy(int Amount, GameObject prefab)
    {
        float[] positions = { -1.6f, 0, 1.6f };

        for (int i = 0; i < Amount; i++)
        {
            float YPosition = Random.Range(0, 20f);
            GameObject go = ObjectPooling.GetObject(prefab);
            go.transform.position = new Vector3(positions[i], transform.position.y + YPosition, transform.position.z);
        }
    }
}
