public class GameItemsFactory
{
    private GameItemsFactoryConfiguration gameItemsConfig;
    public GameItemsFactory(GameItemsFactoryConfiguration gameItemsConfig)
    {
        this.gameItemsConfig = gameItemsConfig;
    }

    public SpawneableObject GetSpawneableObject(string id)
    {
        return gameItemsConfig.GetObjectPrefabById(id);
    }
}