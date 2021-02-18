using FeatherConstruct.Data;

namespace FeatherConstruct.Model
{
    
    public class GameManager
    {

        private static GameManager instance;
        private Construct construct;
        
        public static GameManager Instance => instance != null ? instance :
            instance = new GameManager();
        public static GameConfiguration Configuration;
        public IConstruct Construct => construct;

        private GameManager() { }

        public void Initialize(GameConfiguration gameConfiguration)
        {
            Configuration = gameConfiguration;

            construct = new Construct();
        }

    }

}