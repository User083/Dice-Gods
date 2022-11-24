using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public class SerializationManager
{
       
    //Save
    public static bool Save(string saveName, object saveData)
    {
       
        BinaryFormatter formatter = GetBinaryFormatter();

       //If no save directory exists, create one
        if(!Directory.Exists(Application.persistentDataPath + "/saves"))
        {
            Directory.CreateDirectory(Application.persistentDataPath + "/saves");
        }

        string path = Application.persistentDataPath + "/saves" + saveName + ".JSON";

        FileStream file = File.Create(path);
        formatter.Serialize(file, saveData);
        file.Close();
        return true;
    }
    //Load
    public static object Load(string path)
    {
        //if no save path exists, return null
        if(!File.Exists(path)) 
        {
        return null;
        }

        BinaryFormatter formatter = GetBinaryFormatter();

        //Create filestream at location
        FileStream file = File.Open(path, FileMode.Open);
        
        //Try to load
        try
        {
            object save = formatter.Deserialize(file);
            file.Close();
            return save;
        }
        catch
        {
            Debug.LogErrorFormat("Failed to load file at {0}", path);
            file.Close();
            return null;
        }
    }

    public static BinaryFormatter GetBinaryFormatter()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        return formatter;
    }

    public void SaveCustomCharacters(Character character)
    {
        SaveData.current.customCharacters.Add(character);

    }
}
