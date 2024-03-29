﻿using UniRx;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public static LifeController instance;
    public ReactiveProperty<int> health { get; private set; }

    private void Awake()
    {
        instance = this;
        health = new ReactiveProperty<int>(3);
        health.Subscribe((int hp) =>
        {
            if(hp <= 0) GameStateManager.EndGame();
        });
    }

    public void ReduceLife()
    {
        health.Value--;
    }
    public void GiveLife()
    {
        if (health.Value == 3) return;

        health.Value++;
    }
}