using UnityEditor;
using UnityEngine;

public class SettingsWindow : EditorWindow
{
    [SerializeField] private Settings settings;

    private Editor editor;

    [MenuItem("Window/Game Settings Window")]
     private static void Open()
    {
        GetWindow<SettingsWindow>();
    }

    private void OnGUI()
    {
        settings = (Settings)EditorGUILayout.ObjectField(settings, typeof(Settings), false);

        if (settings == null) return;
        Editor.CreateCachedEditor(settings, null, ref editor);
        editor.OnInspectorGUI();
    }
}
