using UnityEngine;

namespace FeatherConstruct.Data
{

    [CreateAssetMenu(fileName = "GameConfiguration", menuName = "Feather Construct/Data/GameConfiguration")]
    public class GameConfiguration : ScriptableObject
    {

        [Header("GameParameters")]
        [SerializeField] private int maxFeathersCount;
        [SerializeField] private int heightPerFeather;
        [SerializeField] private int winHeight;

        [Header("Feathers Container")]
        [SerializeField] private FeathersContainer feathersContainer;

        [Header("Tone Settings")]
        [SerializeField] private ToneSettings toneSettings;

        public ToneSettings ToneSettings => toneSettings;
        public int MaxFeathersCount => maxFeathersCount;
        public int HeightPerFeather => heightPerFeather;
        public int WinHeight => winHeight;

    }

}