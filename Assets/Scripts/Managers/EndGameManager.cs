using UniRx;
using UnityEngine;

public class EndGameManager : MonoBehaviour
{
    [SerializeField] private GameObject EndGameScreen;


    private void Start()
    {
        GameStateManager.ActualState.Subscribe(EndGame);
    }
    private void EndGame(GameStates gameState)
    {
        if (gameState != GameStates.Lose) return;

        EndGameScreen.SetActive(true);

    }
}