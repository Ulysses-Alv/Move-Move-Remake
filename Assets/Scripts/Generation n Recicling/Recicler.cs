using UnityEngine;

public abstract class Recicler : MonoBehaviour
{
    public abstract void RecicleGO(GameObject GOToRecicle);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        OnTriggerAction(collision);
    }

    protected abstract void OnTriggerAction(Collider2D collision);
}