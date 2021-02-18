using FeatherConstruct.View;
using UnityEngine;

namespace FeatherConstruct.Controllers
{

    public class EndgameMessageController : MonoBehaviour
    {

        [SerializeField] private MessageView view;

        internal void Show()
        {
            gameObject.SetActive(true);
            view.FadeIn();
        }

    }

}