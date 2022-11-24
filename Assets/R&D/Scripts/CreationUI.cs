using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CreationUI : MonoBehaviour
{
    public VisualElement root;
    public Button creationButton;
    public Button saveButton;
    public Button loadButton;
    public Button clearButton;
    public TextField characterName;
    public TextField characterDescription;
    public FloatField characterWeight;
    public FloatField characterValue;
    public FloatField characterHealth;
    public TextField charName;
    public TextField charDescription;
    public FloatField charWeight;
    public FloatField charValue;
    public FloatField charHealth;

    public Character newCharacter;

    public string saveName = "DefaultSave";

    private void OnEnable()
    {
        root = GetComponent<UIDocument>().rootVisualElement;
        creationButton = root.Q<Button>("creationButton");
        saveButton = root.Q<Button>("saveButton");
        loadButton = root.Q<Button>("loadButton");
        clearButton = root.Q<Button>("clearButton");
        characterName = root.Q<TextField>("characterName");
        characterDescription = root.Q<TextField>("characterDescription");
        characterWeight = root.Q<FloatField>("characterWeight");
        characterValue = root.Q<FloatField>("characterValue");
        characterHealth = root.Q<FloatField>("characterHealth");
        charName = root.Q<TextField>("charName");
        charDescription = root.Q<TextField>("charDescription");
        charWeight = root.Q<FloatField>("charWeight");
        charValue = root.Q<FloatField>("charValue");
        charHealth = root.Q<FloatField>("charrHealth");


        creationButton.clicked += () =>
        {
            
            //Create new character and update char UI
           newCharacter = new Character(characterName.value, characterDescription.value, characterWeight.value, characterValue.value, characterHealth.value); 
            if(!CheckValues(characterName.value, characterDescription.value, characterWeight.value, characterValue.value, characterHealth.value))
            {
            Debug.Log("Character details need to be filled in first");
            
            }
            else
            {
               charName.value = newCharacter.actorName;
            charDescription.value = newCharacter.actorDescription;
            charWeight.value = newCharacter.actorWeight;
            charValue.value = newCharacter.actorValue;
            charHealth.value = newCharacter.Health.maxHealth; 
            }
           
        };

        saveButton.clicked += () =>
        {
            SaveData saveData = new SaveData();
            if(newCharacter != null)
            {
                saveData.SaveCustomCharacters(newCharacter);
                SerializationManager.Save("saveName", saveData);
            }
            else
            {
                Debug.Log("No character to save");
            }
           
            
            newCharacter = null;
        };

        loadButton.clicked += () =>
        {
            SerializationManager.Load(Application.persistentDataPath + "/saveName");
        };

        clearButton.clicked += () =>
        {
            
            if(newCharacter != null)
            {
            charName.value = "";
            charDescription.value = "";
            charWeight.value = 0f;
            charValue.value = 0f;
            charHealth.value = 0f;

            characterName.value = "";
            characterDescription.value = "";
            characterWeight.value = 0f;
            characterValue.value = 0f;
            characterHealth.value = 0f;
            }
           

            
        };

       bool CheckValues(string name, string desc, float weight, float value, float health)
        {
            if(name == "" && desc == "" && weight < 0f && value < 0f && health < 1f)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
