using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RecordMenuUI : MonoBehaviour
{
    private TextMeshProUGUI recordText => GetComponent<TextMeshProUGUI>();

    private void Start()
    {
        recordText.text = $"Your record: {RecordSaveManager.LoadRecord()}";
    }
}
