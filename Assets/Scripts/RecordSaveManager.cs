using UnityEngine;

public static class RecordSaveManager
{
    public static void SaveRecord(float record)
    {
        PlayerPrefs.SetFloat("Record", record);
    }

    public static float LoadRecord()
    {
        return PlayerPrefs.GetFloat("Record");
    }
}