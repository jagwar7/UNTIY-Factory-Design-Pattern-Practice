using UnityEngine;
using System.Collections.Generic;



public class MasterCharacterFactory : BaseCharacterFactory
{
    [Header("All possible characters in a list")]
    [SerializeField] private List<CharacterData> allCharacterData;
    private Dictionary<CharacterData, GameObject> prefabLookup;



    /*  --------------------------------------------------------------------------------------
        MASTER CHARACTER FACTORY WILL CONTAIN A LIST OF CHARACTER DATA(SCRIPTABLE OBJECT)
        FOR FIRST TIME IT WILL MAKE A KVP MAP IN DICTIONARY FOR O(1) LOOKUP
        USED CHARACTER OBJECT AS KEY INSTEAD OF STRING BECAUSE OF EFFICIENT HASHING SPEED

        THE LIST OF SCRIPTABLE OBJECT IS A SINGLE SOURCE OF TRUTCH, ITS IN FUTURE IF WE WANT TO
        RENDER ALL THE ITEMS TO THE UI (FOR A SCROLLABLE LIST) THEN WE DONT NEED TO CREATE A
        SEPAREATE LIST TO RENDER ITEMS , WE CAN USE THE EXISTING LIST TO RENDER ITEMS ON UI
        --------------------------------------------------------------------------------------
    */

    void Awake()
    {   
        prefabLookup = new Dictionary<CharacterData, GameObject>();
        foreach(var characterData in allCharacterData)
        {
            prefabLookup[characterData] = characterData.characterPrefab;
        }
    }





    /*
        CAN CREATE CHARACTER BY PASSED SPECIFIC SCRIPTABLE OBJECT
    */
    public ICharacter CreateCharacterFromData(CharacterData data)
    {
        if(prefabLookup.TryGetValue(data, out GameObject prefab))
        {
            GameObject characterObj = Instantiate(prefab);
            UniversalCharacter characterUnit = characterObj.GetComponent<UniversalCharacter>();
            
            if(characterUnit != null)
            {
                characterUnit.characterData = data;
                return characterUnit; 
            }
        }
        return null;
    }



    public override ICharacter CreateCharacter() 
    {
        if (allCharacterData.Count > 0)
        {
            return CreateCharacterFromData(allCharacterData[0]);
        }
        return null;
    }
}