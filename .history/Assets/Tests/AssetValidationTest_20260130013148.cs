using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEditor;
using Project.Core;

public class AssetValidationTest
{
    [Test]
    public void Factory_Assets_Have_Valid_Prefabs()
    {
        // FIND ALL SCRIPTABLE OBJECTS OF TYPE CharacterData IN ASSETS FOLDER
        // THIS IS A STATIC ANALYSIS
        string[] guids = AssetDatabase.FindAssets("t:CharacterData");

        Assert.Greater(guids.Length, 0, "No CharacterData found. Did you created the CharacterData scriptable obejct yet ?");

        foreach(string guid in guids)
        {
            // BRING / LOAD THE CharacterData object FROM PATH
            string path = AssetDatabase.GUIDToAssetPath(guid);
            CharacterData characterData = AssetDatabase.LoadAssetAtPath<CharacterData>(path);

            // CHECK IF CHARACTER PREFAB GAME OBJECT IS PRESENT IN SCRIPTABLE OBJECT
            Assert.IsNotNull(characterData.characterPrefab, $"Error: CharacterData at {path} is a missing prefab. Please check the prefab GameObject field");
            
            // CHECK IF CHARACTER PREFAB GAME OBJECT IS PRESENT IN SCRIPTABLE OBJECT
            Assert.IsFalse(string.IsNullOrEmpty(characterData.name), $"Error: CharacterData at {path} has no name. Please check the name field");

            // CHECK IF CHARACTER WALKING SPEED IS NOT ZERO
            Assert.Greater(characterData.speed, 0, $"Error: CharacterData at {path} having speed value : 0   Character is unable to move");

            // CHECK IF CHARACTER HEALTH IS NOT ZERO
            Assert.LessOrEqual()
        }
    }
}
