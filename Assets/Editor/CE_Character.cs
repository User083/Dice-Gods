using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;

public class AssetHandler
{
    [OnOpenAsset()]
    public static bool OpenEditor(int instanceID, int line)
    {
        ScriptableObject scriptableObject = EditorUtility.InstanceIDToObject(instanceID) as ScriptableObject;

        if(scriptableObject != null)
        {
            CustomWindow.Open(scriptableObject);
            return true;
        }
        return false;
    }
}

[CustomEditor(typeof(ScriptableObject))]
public class CE_Character : Editor
{
    public override void OnInspectorGUI()
    {
        if(GUILayout.Button("Open Editor"))
        {
            CustomWindow.Open((ScriptableObject) target);
        }
    }

}
