using UnityEngine;
using System.Collections.Generic;
using FeatherConstruct.Model;

namespace FeatherConstruct.Data
{

    [CreateAssetMenu(fileName = "ToneSettings", menuName = "Feather Construct/Data/ToneSettings")]
    public class ToneSettings : ScriptableObject
    {

        [SerializeField] public List<ToneData> Tones;

        public static IEnumerable<string> ToneNames
        {
            get
            {
                foreach (var item in GameManager.Instance.Configuration.ToneSettings.Tones)
                {
                    yield return item.Name;
                }
            }
        }

        public ToneData GetToneById(int id) =>  id >= 0 && id < Tones.Count ? Tones[id] : null;

    }

    [System.Serializable]
    public class ToneData
    {
        public string Name;
        public Color Color;

        public ToneData(string name, Color color)
        {
            Name = name;
            Color = color;
        }
    }

}