using TMPro;
using UnityEngine;

public class RecordTextUI : MonoBehaviour
{
    private TextMeshProUGUI recordText;

    private void OnEnable()
    {
        recordText = GetComponent<TextMeshProUGUI>();

        int currentValue = (int)RecordSaveManager.LoadRecord();
        int score = (int)GameTimerManager.instance.time;

        recordText.enabled = score > currentValue;

        if (score > currentValue) RecordSaveManager.SaveRecord(score);
    }
}
