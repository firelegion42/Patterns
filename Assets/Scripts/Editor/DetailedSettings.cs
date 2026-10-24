using UnityEditor;
using UnityEngine;

public class DetailedSettings : EditorWindow
{
    private Settings settings;

    [MenuItem("Window/Adjustable Game Settings")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(DetailedSettings));
    }

    private void OnGUI()
    {
        settings = (Settings)EditorGUILayout.ObjectField("Settings", settings, typeof(Settings), false);

        if(settings == null)
        {
            return;
        }

        GUILayout.Label("AdjustableGameSettings", EditorStyles.boldLabel);

        settings.playerMaxHealth = EditorGUILayout.FloatField("Player Max Health", settings.playerMaxHealth);
    }
}
