using System;
using UniRx;
using UnityEngine;

public class GameTimerManager : MonoBehaviour
{
    public static GameTimerManager instance;

    public float time { get; private set; }
    public int minutes { get; private set; }
    public int seconds { get; private set; }
    public int miles { get; private set; }

    public ReactiveProperty<int> secondsProperty = new ReactiveProperty<int>(initialValue: 0);

    Action timer;
    
    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        GameStateManager.instance.ActualState.Subscribe(PauseTimer);
        timer = UpdateTimer;
    }

    private void Update()
    {
        timer?.Invoke();
    }

    private void UpdateTimer()
    {
        time += Time.deltaTime;
        minutes = (int)time / 60;
        seconds = (int)time % 60;
        miles = (int)((time * 1000) % 1000);
        secondsProperty.Value = seconds;
    }
    private void PauseTimer(GameStates gameState)
    {
        if (gameState != GameStates.Lose) return;

        Debug.LogWarning("PERDISTE");
        timer = null;
    }
}
