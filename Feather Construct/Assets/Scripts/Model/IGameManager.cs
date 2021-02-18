using System;
using FeatherConstruct.Data;
using UniRx;

namespace FeatherConstruct.Model
{

    public interface IGameManager
    {

        GameConfiguration Configuration { get; }
        IConstruct Construct { get; }
        bool IsEngame { get; }

        IObservable<bool> EndgameAsObservable();
        void Initialize(GameConfiguration gameConfiguration);
        void Win();

    }

}