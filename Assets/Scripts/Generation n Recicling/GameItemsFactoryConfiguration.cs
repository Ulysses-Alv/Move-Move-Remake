using UnityEngine;
using System.Collections.Generic;
using System;

[CreateAssetMenu(menuName = "Custom/Basic Configuration")]
public class GameItemsFactoryConfiguration : ScriptableObject
{
    [SerializeField] public SpawneableObject[] spawneableObjects;
    private Dictionary<string, SpawneableObject> idToObj;
    public List<string> ids;

    private void Awake()
    {
        idToObj = new Dictionary<string, SpawneableObject>(spawneableObjects.Length);

        foreach (SpawneableObject spawneableObject in spawneableObjects)
        {
            idToObj.Add(spawneableObject.Id, spawneableObject);
            ids.Add(spawneableObject.Id);
        }
    }
    public SpawneableObject GetObjectPrefabById(string id)
    {
        if (!idToObj.TryGetValue(id, out SpawneableObject objectToReturn))
        {
            throw new Exception($"{id} Doesn't exist");
        }
        return objectToReturn;
    }
}
