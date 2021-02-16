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
    public struct FeatherData
    {
        public int Id;
        [ToneName] public string ToneName;
    }


}