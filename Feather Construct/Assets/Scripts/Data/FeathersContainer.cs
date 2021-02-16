using UnityEngine;
using System.Collections.Generic;

namespace FeatherConstruct.Data
{

    [CreateAssetMenu(fileName = "FeathersContainer", menuName = "Feather Construct/Data/FeathersContainer")]
    public class FeathersContainer : ScriptableObject
    {

        [SerializeField] public List<FeatherData> Feathers;

    }

    [System.Serializable]
    public class FeatherData
    {
        [SerializeField] [ReadOnly] private string id;
        [SerializeField] [ToneName] private int toneId;

        public int ToneId => toneId;

        public void SetupId(string newId) => id = newId;

        public FeatherData(string id)
        {
            this.id = id;
        }
    }


}