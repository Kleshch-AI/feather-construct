using FeatherConstruct.Data;

namespace FeatherConstruct.Model
{

    public class GameManager : IGameManager
    {

        private static GameManager instance;
        private static GameConfiguration configuration;
        private Construct construct;

        public static IGameManager Instance => instance != null ? instance :
            instance = new GameManager();

        GameConfiguration IGameManager.Configuration => configuration;
        IConstruct IGameManager.Construct => construct;

        private GameManager() { }

        void IGameManager.Initialize(GameConfiguration gameConfiguration)
        {
            configuration = gameConfiguration;

            construct = new Construct();
        }

        void IGameManager.Win()
        {
            UnityEngine.Debug.Log("!!! win !!!");
        }

    }

}