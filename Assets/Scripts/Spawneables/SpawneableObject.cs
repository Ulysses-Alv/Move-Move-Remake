using UnityEngine;

public abstract class SpawneableObject : MonoBehaviour
{
    [SerializeField] protected string id;
    public string Id => id;
    private void OnEnable()
    {
        AddForce();
    }
    protected abstract void AddForce();
}
