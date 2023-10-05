using UnityEditor;
using UnityEngine;

[InitializeOnLoad]
[CustomEditor(typeof(LogSettings))]
public class LogSettingEditor : Editor
{
    [MenuItem("Assets/Logger/Log Settings")]
    public static void OpenInspector()
    {
        Selection.activeObject = LogSettings.LoadInstance();
    }
}


