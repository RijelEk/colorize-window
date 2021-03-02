using UnityEngine;
using UnityEditor;

public class ColorizeWindow: EditorWindow
{
    Color color;

    [MenuItem("Window/Colorizer")]
    public static void ShowWindow()
    {
        GetWindow<ColorizeWindow>("Colorizer");
    }

    private void OnGUI()
    {
        GUILayout.Label("Colorize selected object", EditorStyles.boldLabel);
        color = EditorGUILayout.ColorField("Color", color);

        if (GUILayout.Button("Colorize"))
        {

            Colorize();

        }
    }

    void Colorize()
    {
        foreach(GameObject obj in Selection.gameObjects)
        {
            Renderer renderer = obj.GetComponent<Renderer>();
            if(renderer != null)
            {
                renderer.sharedMaterial.color = color;
            }
        }
    }
}