using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CustomWindow : ExtendedEditorWindow
{
    
    public static void Open(ScriptableObject scriptableObject)
    {
        CustomWindow window = GetWindow<CustomWindow>("Scriptable Object Editor");
        window.serializedObject = new SerializedObject(scriptableObject);
    }

    private void OnGUI()
    {
       //custom window WIP colour code
        GUI.DrawTexture(new Rect(0, 0, maxSize.x, maxSize.y), EditorGUIUtility.whiteTexture, ScaleMode.StretchToFill);
        GUI.Label(new Rect(200, 200, 100, 100), "A label");
        GUI.TextField(new Rect(20, 20, 70, 30), "");
        //Custom window layout
        currentProperty = serializedObject.FindProperty("characterAttributes");
        EditorGUILayout.BeginHorizontal();
        EditorGUILayout.BeginVertical("box", GUILayout.MaxWidth(150), GUILayout.ExpandHeight(true));
        DrawSidebar(currentProperty);
        EditorGUILayout.EndVertical();
        EditorGUILayout.BeginVertical("box", GUILayout.ExpandHeight(true));

        if(selectedProperty!= null)
        {
            DrawProperties(selectedProperty, true);
            
        }
        else
        {
            EditorGUILayout.LabelField("Select an item from the list");
        }
        EditorGUILayout.EndVertical();
        EditorGUILayout.EndHorizontal();
        //Applies changes made in editor
        Apply();

    }

    //Not currently in use - in order to draw individual fields
    void DrawSelectedPropertiesPanel()
    {
        currentProperty = selectedProperty;

        EditorGUILayout.BeginHorizontal("box");
        DrawField("characterName", true);
        DrawField("characterDescription", true);
        DrawField("characterDefense", true);
        DrawField("characterStamina", true);

        EditorGUILayout.EndHorizontal();
    }
}
