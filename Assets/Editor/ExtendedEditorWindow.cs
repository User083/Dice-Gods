using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ExtendedEditorWindow : EditorWindow
{
    protected SerializedObject serializedObject;
    protected SerializedProperty currentProperty;

    private string selectedPropertyPath;
    protected SerializedProperty selectedProperty;

    //Reads all serialised properties of object and lays them out as it would in inspector
    protected void DrawProperties(SerializedProperty property, bool drawChildren)
    {
        string lastPropPath = string.Empty;
        foreach(SerializedProperty prop in property)
        {
            //handles display of arrays
            if(prop.isArray && prop.propertyType == SerializedPropertyType.Generic) 
            {
                lastPropPath = prop.propertyPath;
                EditorGUILayout.BeginHorizontal();
                prop.isExpanded = EditorGUILayout.Foldout(prop.isExpanded, prop.displayName);
                EditorGUILayout.EndHorizontal();
                 
                if(prop.isExpanded)
                   {
                        EditorGUI.indentLevel++;
                        DrawProperties(prop, drawChildren);
                         EditorGUI.indentLevel--;
                   }

            }
            else
            {
                if(!string.IsNullOrEmpty(lastPropPath) && prop.propertyPath.Contains(lastPropPath)) { continue; }
                lastPropPath = prop.propertyPath;
                EditorGUILayout.PropertyField(prop, drawChildren);
            }

        }
    }

    //Draws a sidebar with buttons for each individual element
    protected void DrawSidebar(SerializedProperty property)
    {
        foreach(SerializedProperty prop in property)
        {
            if(GUILayout.Button(prop.displayName))
            {
                selectedPropertyPath = prop.propertyPath;
            }
        }
        if(!string.IsNullOrEmpty(selectedPropertyPath))
        {
            selectedProperty = serializedObject.FindProperty(selectedPropertyPath);
        }
    }

    protected void DrawField(string propertyName, bool relative)
    {
        if(relative && currentProperty !=null)
        {
            EditorGUILayout.PropertyField(currentProperty.FindPropertyRelative(propertyName), true);
        }
        else if(serializedObject != null)
        {
            EditorGUILayout.PropertyField(serializedObject.FindProperty(propertyName), true);
        }
    }

    protected void Apply()
    {
        serializedObject.ApplyModifiedProperties();
    }
}
