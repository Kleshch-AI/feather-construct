using UnityEngine;
using UnityEditor;
using FeatherConstruct.Data;
using System.Linq;

namespace FeatherConstruct.EditorSettings
{

    [CustomPropertyDrawer(typeof(ToneNameAttribute))]
    public class ToneNameDrawer : PropertyDrawer
    {

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            var names = ToneSettings.ToneNames.ToArray();

            if (property.propertyType == SerializedPropertyType.Integer)
            {
                property.intValue = EditorGUI.Popup(position, label.text, property.intValue, names);
            }
            else if (property.propertyType == SerializedPropertyType.String)
            {
                var selected = names.ToList().FindIndex(x => x == property.stringValue);
                selected = selected >= 0 && selected < names.Length ? selected : 0;
                property.stringValue = names[EditorGUI.Popup(position, label.text, selected, names)];
            }
            else
            {
                EditorGUI.LabelField(position, label.text, "Use [ToneName] with string or integer type field.");
            }
        }

    }

}