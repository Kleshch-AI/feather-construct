using FeatherConstruct.Data;
using FeatherConstruct.Model;
using UnityEngine;

namespace FeatherConstruct.Controllers
{

    public class InitializationController : MonoBehaviour
    {

        [SerializeField] private GameConfiguration gameConfiguration;

        private void Awake()
        {
            InitializeGame();
        }

        private void InitializeGame()
        {
            GameManager.Instance.Initialize(gameConfiguration);
        }

    }

}