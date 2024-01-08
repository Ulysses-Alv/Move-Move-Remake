using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class InputGameManager : MonoBehaviour
{
    [SerializeField] private PlayerInputs playerInput;

    private void Awake()
    {
        playerInput = new PlayerInputs();

        playerInput.Game.Enable();
        playerInput.Game.RestartGame.performed += Restart;
    }

    private void Restart(InputAction.CallbackContext obj)
    {
        if (!StatesBool.IsLose()) return;

        GameStateManager.StartGame();
        SceneManager.LoadScene("Game");
    }

    private void MovePlayer(Vector2 input)
    {
        PlayerController.instance.Move(input);
    }
    private void Update()
    {
        if (StatesBool.IsLose()) return;

        Vector2 input = playerInput.Game.Movement.ReadValue<Vector2>();

        MovePlayer(input);
    }
}
