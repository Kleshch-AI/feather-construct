using UnityEngine;
using UnityEditor;
using FeatherConstruct.Data;
using System.Collections.Generic;
using System.Linq;

namespace FeatherConstruct.EditorSettings
{

    [CustomEditor(typeof(FeathersContainer))]
    public class FeathersContainerEditor : Editor
    {

        private const string featherIdFormat = "f.{0:D2}";

        private FeathersContainer fc;
        private FeathersContainer FC => fc ? fc : fc = target as FeathersContainer;


        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            var feathersProperty = serializedObject.FindProperty("Feathers");
            EditorList.Show(feathersProperty);
            if (feathersProperty.isExpanded)
            {
                GUILayout.Space(20);
                if (GUILayout.Button("+")) ProcessAddButton();
            }

            serializedObject.ApplyModifiedProperties();

            ShowStats();

            GUILayout.Space(20);
            var style = new GUIStyle(GUI.skin.button);
            style.normal.textColor = Color.red;
            if (GUILayout.Button("Clear All", style)) ProcessClearButton();

            if (GUI.changed)
            {
                EditorUtility.SetDirty(target);
                UpdateIds();
            }
        }

        private void ShowStats()
        {
            GUILayout.Space(20);

            var style = new GUIStyle(GUI.skin.textField);
            style.normal.textColor = Color.white;
            style.fontStyle = FontStyle.Bold;

            EditorGUILayout.LabelField("Stats", style);

            var statistics = new Dictionary<int, int>();
            var toneNames = ToneSettings.ToneNames.ToArray();
            for (var i = 0; i < toneNames.Length; i++) statistics.Add(i, 0);
            foreach (var f in FC.Feathers) statistics[f.ToneId]++;
            style.fontStyle = FontStyle.Italic;
            foreach (var stat in statistics) GUILayout.Label($"{toneNames[stat.Key]}: {stat.Value}", style);
        }

        private void UpdateIds()
        {
            for (var i = 0; i < FC.Feathers.Count; i++)
            {
                FC.Feathers[i].SetupId(string.Format(featherIdFormat, i));
            }
        }

        private void ProcessAddButton()
        {
            FC.Feathers.Add(new FeatherData(string.Format(featherIdFormat, FC.Feathers.Count)));
        }

        private void ProcessClearButton()
        {
            FC.Feathers.Clear();
        }

    }

}