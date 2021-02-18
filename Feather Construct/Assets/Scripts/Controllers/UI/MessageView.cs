using System.Collections;
using UnityEngine;

namespace FeatherConstruct.View
{

    public class MessageView : MonoBehaviour
    {

        [SerializeField] private CanvasGroup cg;

        [Header("Settings")]
        [SerializeField] private float fadeInSpeed;

        public void FadeIn() => StartCoroutine(AnimateFadeIn());
        
        private IEnumerator AnimateFadeIn()
        {
            cg.alpha = 0;
               
            var startValue = 0f;
            var endValue = 1f;
            var value = startValue;
            var startTime = Time.time;

            while (value < endValue)
            {
                var factor = (Time.time - startTime) / fadeInSpeed;
                value = Mathf.Lerp(startValue, endValue, factor);
                cg.alpha = value;

                yield return new WaitForEndOfFrame();
            }
        }

    }

}