using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(MapEditor))]
public class LevelEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        MapEditor map = (MapEditor)target;

        if (GUILayout.Button("Generate Level"))
        {
            map.GenerateLevel();
        }
    }
}
