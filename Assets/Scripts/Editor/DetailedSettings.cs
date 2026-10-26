using Codice.Client.BaseCommands.BranchExplorer.Layout;
using UnityEditor;
using UnityEngine;

public class DetailedSettings : EditorWindow
{
    private Settings settings;

    private int number;

    private Color color;

    [MenuItem("Window/Adjustable Game Settings")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow(typeof(DetailedSettings));
    }

    private void OnGUI()
    {
        settings = (Settings)EditorGUILayout.ObjectField("Settings", settings, typeof(Settings), false);

        if (settings == null)
        {
            return;
        }

        GUILayout.Label("AdjustableGameSettings", EditorStyles.boldLabel);

        settings.playerMaxHealth = EditorGUILayout.FloatField("Player Max Health", settings.playerMaxHealth);

        GUILayout.Label("Adjust Player Health", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("+ 10 health"))
        {
            settings.playerMaxHealth += 10;
        }
        if (GUILayout.Button("- 10 health"))
        {
            settings.playerMaxHealth -= 10;
        }
        if (GUILayout.Button("+ 1 health"))
        {
            settings.playerMaxHealth += 1;
        }
        if (GUILayout.Button("- 1 health"))
        {
            settings.playerMaxHealth -= 1;
        }

        EditorGUILayout.EndHorizontal();

        settings.enemyMaxHealth = EditorGUILayout.FloatField("Enemy Max Health", settings.enemyMaxHealth);

        GUILayout.Label("Adjust Enemy Health", EditorStyles.boldLabel);
        EditorGUILayout.BeginHorizontal();
        if (GUILayout.Button("+ 10 health"))
        {
            settings.playerMaxHealth += 10;
        }
        if (GUILayout.Button("- 10 health"))
        {
            settings.playerMaxHealth -= 10;
        }
        if (GUILayout.Button("+ 1 health"))
        {
            settings.playerMaxHealth += 1;
        }
        if (GUILayout.Button("- 1 health"))
        {
            settings.playerMaxHealth -= 1;
        }

        EditorGUILayout.EndHorizontal();

        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Change color"))
        {
            ChangeColor();
        }
    }

    private void ChangeColor()
    {
        foreach (GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if (renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }
}

    
