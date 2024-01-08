using UniRx;

public static class GameStateManager
{

    public static ReactiveProperty<GameStates> ActualState { get; private set; }

    public static void SetUp()
    {
        ActualState = new ReactiveProperty<GameStates>(initialValue: GameStates.Menu);
    }
    public static void StartGame()
    {
        ActualState.Value = GameStates.Playing;
    }
    public static void EndGame()
    {
        ActualState.Value = GameStates.Lose;
    }
    public static void PauseGame()
    {
        ActualState.Value = GameStates.Paused;
    }
}

public static class StatesBool
{
    public static bool IsMenu()
    {
        return GameStateManager.ActualState.Value == GameStates.Menu;
    }

    public static bool IsPlaying()
    {
        return GameStateManager.ActualState.Value == GameStates.Playing;
    }

    public static bool IsLose()
    {
        return GameStateManager.ActualState.Value == GameStates.Lose;
    }

    public static bool IsPaused()
    {
        return GameStateManager.ActualState.Value == GameStates.Paused;
    }
}
public enum GameStates
{
    Menu, Playing, Lose, Paused
}
