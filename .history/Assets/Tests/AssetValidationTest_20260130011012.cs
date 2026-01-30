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
        string characterDataCollection = AssetDatabase.FindAssets("t:CharacterData")
    }
}
