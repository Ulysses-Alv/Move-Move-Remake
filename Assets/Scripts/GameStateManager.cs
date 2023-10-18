using UniRx;
using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager instance;

    public ReactiveProperty<GameStates> ActualState { get; private set; }

    private void Awake()
    {
        ActualState = new ReactiveProperty<GameStates>(initialValue: GameStates.Starting);
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != null && instance != this)
        {
            Destroy(this);
        } 
    }
    private void Start()
    {
        LifeController.instance.health.Subscribe(EndGame);
    }
    public void EndGame(int health)
    {
        if(health <= 0) ActualState.Value = GameStates.Lose;
    }
}
