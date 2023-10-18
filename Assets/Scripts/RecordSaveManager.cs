using UnityEngine;

public class RecordSaveManager : MonoBehaviour
{
    public static RecordSaveManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    public void SaveRecord(float record)
    {
        PlayerPrefs.SetFloat("Record", record);
    }

    public float LoadRecord()
    {
        return PlayerPrefs.GetFloat("Record");
    }
}