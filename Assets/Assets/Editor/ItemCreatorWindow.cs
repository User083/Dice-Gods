
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Reflection;
using System;

public class ItemCreatorWindow : ExtendedEditorWindow
{
  
    PropertyInfo[] properties = typeof(Item).GetProperties();

    [MenuItem("Window/Item Creation")]
    public static void ShowWindow(Item item)
    {
       ItemCreatorWindow window = GetWindow<ItemCreatorWindow>("Item Creation");
        


    }
    void OnGUI()
    {
        //window code
        EditorGUILayout.Space(10);
        
       for (int i = 0; i < properties.Length; i++)
        {
            if (properties[i].PropertyType == typeof(string))
            {
                EditorGUILayout.BeginHorizontal();
               
                GUILayout.Label(properties[i].Name);
                
               
                EditorGUILayout.TextField("");
                
                EditorGUILayout.EndHorizontal();
            }
            else if(properties[i].PropertyType == typeof(float))
            {
                EditorGUILayout.BeginHorizontal();

                GUILayout.Label(properties[i].Name);


                EditorGUILayout.FloatField(0);

                EditorGUILayout.EndHorizontal();
            }
           
        }
        EditorGUILayout.BeginHorizontal();
        GUILayout.Button("Save");
        GUILayout.Button("Clear");
        EditorGUILayout.EndHorizontal();








    }

}
