using TMPro;
using UnityEngine;

public class ScoreTextUI : MonoBehaviour
{
    private TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        scoreText = GetComponent<TextMeshProUGUI>();

        int timeText = (int)GameTimerManager.instance.time;
        scoreText.text = string.Format("Score: {0}", timeText);
    }
}