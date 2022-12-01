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
        currentProperty = serializedObject.FindProperty("SO_Character");
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
