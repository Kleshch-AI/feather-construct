using UnityEngine;
using UnityEditor;
using FeatherConstruct.Data;

namespace FeatherConstruct.EditorSettings
{

    [CustomEditor(typeof(ToneSettings))]
    public class ToneSettingsEditor : Editor
    {

        public override void OnInspectorGUI()
        {
            serializedObject.Update();
            EditorList.Show(serializedObject.FindProperty("Tones"));

            var ts = target as ToneSettings;
            GUILayout.Space(20);
            if (GUILayout.Button("+"))
            {
                ts.Tones.Add(new ToneData("White", Color.white));
            }

            serializedObject.ApplyModifiedProperties();
            if (GUI.changed) EditorUtility.SetDirty(target);

        }

    }

}