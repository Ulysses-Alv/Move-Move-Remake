using UnityEngine;

public class StartMenu : MonoBehaviour
{
    private void Awake()
    {
        GameStateManager.SetUp();
    }
    private void Start()
    {
        Application.targetFrameRate = 60;
    }
}
