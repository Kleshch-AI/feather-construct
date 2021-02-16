using UnityEngine;
using UnityEditor;
using FeatherConstruct.Data;
using System.Linq;

[CustomPropertyDrawer(typeof(ToneNameAttribute))]
public class ToneNameDrawer : PropertyDrawer
{

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        var names = ToneSettings.ToneNames;
        EditorGUI.Popup(position, 0, names.ToArray());
    }

}

