using UnityEngine;

public class PowerUpRecicler : Recicler
{
    public static PowerUpRecicler instance;

    [SerializeField] private GameObject ShieldPrefab;
    [SerializeField] private GameObject ExtraLifePrefab;

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
        prefabs = new GameObject[] { ShieldPrefab, ExtraLifePrefab };
    }

    public override void RecicleGO(GameObject powerUp)
    {
        var id = powerUp.GetComponent<SpawneableObject>().Id;

        foreach (GameObject go in prefabs)
        {
            if (id != go.GetComponent<SpawneableObject>().Id) continue;
            
            ObjectPooling.RecicleObject(go, powerUp);
        }
    }

    protected override void OnTriggerAction(Collider2D collision)
    {
        if (!collision.gameObject.CompareTag("PowerUp")) return;

        RecicleGO(collision.gameObject);
    }
}
