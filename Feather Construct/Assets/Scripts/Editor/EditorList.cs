using UnityEditor;
using UnityEngine;

public static class EditorList
{

    public static void Show(SerializedProperty list)
    {
        EditorGUILayout.PropertyField(list, false);

        if (list.isExpanded)
        {
            EditorGUI.indentLevel++;
            GUILayout.Label($"Size: {list.arraySize}");

            var style = new GUIStyle(GUI.skin.button);
            style.margin = new RectOffset(48, 0, 0, 0);

            for (var i = 0; i < list.arraySize; i++)
            {
                var item = list.GetArrayElementAtIndex(i);
                EditorGUILayout.PropertyField(item);
                if (item.isExpanded)
                {
                    if (GUILayout.Button("-", style))
                    {
                        list.DeleteArrayElementAtIndex(i);
                    }
                }
            }

            EditorGUI.indentLevel--;
        }

    }

}