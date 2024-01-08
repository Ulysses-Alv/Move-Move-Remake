using UnityEngine;
using UniRx;
using System;
using System.Collections;

public class SpawnerTimer : MonoBehaviour
{
    [HideInInspector] public float timeBetweenSpawn;
    public ReactiveProperty<int> genCount { get; private set; }

    private float timer;
    private float timeToFirstSpawn = 5f;

    private Action timerAction;

    private void Awake()
    {
        genCount = new ReactiveProperty<int>(initialValue: 0);
    }
    private void Start()
    {
        GameStateManager.ActualState.Subscribe(PauseTimer);
    }

    private IEnumerator StartTimer()
    {
        yield return new WaitForSeconds(timeToFirstSpawn);
        genCount.Value = 0;
        timerAction = Timer;
    }

    private void PauseTimer(GameStates gameState)
    {
        if (gameState != GameStates.Lose) return;
        timerAction = null;
    }

    private void Update()
    {
        timerAction?.Invoke();
    }

    private void Timer()
    {
        timer += Time.deltaTime;

        if (timer > timeBetweenSpawn)
        {
            timer -= timeBetweenSpawn;
            genCount.Value++;
        }
    }
    public void RestartTimer(float timeBetweenSpawn)
    {
        timerAction = null;
        this.timeBetweenSpawn = timeBetweenSpawn;
        StartCoroutine(StartTimer());
    }
}
