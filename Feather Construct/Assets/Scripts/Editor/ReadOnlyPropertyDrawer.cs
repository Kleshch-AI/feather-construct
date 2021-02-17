using UnityEngine;
using UnityEditor;
using FeatherConstruct.Utils;

namespace FeatherConstruct.EditorSettings
{

    [CustomPropertyDrawer(typeof(ReadOnlyAttribute))]
    public class ReadOnlyDrawer : PropertyDrawer
    {

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            EditorGUI.LabelField(position, label.text, $"{PropertyUtils.GetPropertyValue(property)}");
        }

    }

}