using FeatherConstruct.Data;

namespace FeatherConstruct.Model
{

    public interface IGameManager
    {

        GameConfiguration Configuration { get; }
        IConstruct Construct { get; }

        void Initialize(GameConfiguration gameConfiguration);
        void Win();

    }

}