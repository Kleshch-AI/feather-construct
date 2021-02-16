using UnityEngine;
using System.Collections.Generic;

namespace FeatherConstruct.Data
{

    [CreateAssetMenu(fileName = "ToneSettings", menuName = "Feather Construct/Data/ToneSettings")]
    public class ToneSettings : SingletonScriptableObject<ToneSettings>
    {

        [SerializeField] public List<ToneData> Tones;

        public static IEnumerable<string> ToneNames
        {
            get
            {
                foreach (var item in Instance.Tones)
                {
                    yield return item.Name;
                }
            }
        }

    }

    [System.Serializable]
    public struct ToneData
    {
        public string Name;
        public Color Color;
    }

}