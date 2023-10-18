using TMPro;
using UnityEngine;

public class RecordTextUI : MonoBehaviour
{
    private TextMeshProUGUI recordText;

    private void OnEnable()
    {
        recordText = GetComponent<TextMeshProUGUI>();

        int currentValue = (int)RecordSaveManager.Instance.LoadRecord();
        int score = (int)GameTimerManager.instance.time;

        recordText.enabled = score > currentValue;

        if (score > currentValue) RecordSaveManager.Instance.SaveRecord(score);
    }
}
