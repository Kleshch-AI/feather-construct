using System;
using FeatherConstruct.Data;
using UniRx;

namespace FeatherConstruct.Model
{

    public class GameManager : IGameManager
    {

        private static GameManager instance;
        private static GameConfiguration configuration;
        private Construct construct;
        private BoolReactiveProperty endgame = new BoolReactiveProperty();

        public static IGameManager Instance => instance != null ? instance :
            instance = new GameManager();

        GameConfiguration IGameManager.Configuration => configuration;
        IConstruct IGameManager.Construct => construct;
        bool IGameManager.IsEngame => endgame.Value;

        private GameManager() { }

        void IGameManager.Initialize(GameConfiguration gameConfiguration)
        {
            configuration = gameConfiguration;

            construct = new Construct();
        }

        void IGameManager.Win()
        {
            UnityEngine.Debug.Log("!!! win !!!");
            endgame.Value = true;
        }

        IObservable<bool> IGameManager.EndgameAsObservable() => endgame;

    }

}