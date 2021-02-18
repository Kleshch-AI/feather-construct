using FeatherConstruct.Model;
using UnityEngine;
using UniRx;

namespace FeatherConstruct.Controllers
{

    public class UIController : MonoBehaviour
    {

        [SerializeField] private EndgameMessageController endgameMessage;

        private void Start()
        {
            GameManager.Instance.EndgameAsObservable().Subscribe(ProcessEndgame).AddTo(this);
        }

        private void ProcessEndgame(bool endgame)
        {
            if (endgame) endgameMessage.Show();
        }

    }

}