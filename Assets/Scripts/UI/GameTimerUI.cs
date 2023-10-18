using System;
using TMPro;
using UniRx;
using UnityEngine;

public class GameTimerUI : MonoBehaviour
{
    private TextMeshProUGUI textMeshPro;
    private Action timer;

    private void Awake()
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    private void Start()
    {
        GameStateManager.instance.ActualState.Subscribe(PauseTimer);
        timer = UpdateTextUI;
    }

    private void Update()
    {
        timer?.Invoke();
    }

    private void UpdateTextUI()
    {
        int minutes = GameTimerManager.instance.minutes;
        int seconds = GameTimerManager.instance.seconds;
        int miles = GameTimerManager.instance.miles;

        string _miles = "<size=" + textMeshPro.fontSize / 2 + ">" + miles.ToString("000") + "</size>";
        if (minutes == 0)
        {
            textMeshPro.text = string.Format("{0}:{1}", seconds, _miles);
        }
        else
        {
            textMeshPro.text = string.Format("{0}:{1}:{2}", minutes, seconds, _miles);
        }
    }

    private void PauseTimer(GameStates gameState)
    {
        if (gameState != GameStates.Lose) return;

        Debug.LogWarning("PERDISTE");
        timer = null;
    }
}
