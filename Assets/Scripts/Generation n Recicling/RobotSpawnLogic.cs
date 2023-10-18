using UnityEngine;

public class RobotSpawnLogic : EnemySpawnLogic
{
    public override void SpawnEnemy(int Amount, GameObject prefab)
    {
        float[] positions = { -2f, 0, 2f };

        for (int i = 0; i < Amount; i++)
        {
            GameObject go = ObjectPooling.GetObject(prefab);
            go.transform.position = new Vector3(positions[i], transform.position.y, transform.position.z);
        }
    }
}