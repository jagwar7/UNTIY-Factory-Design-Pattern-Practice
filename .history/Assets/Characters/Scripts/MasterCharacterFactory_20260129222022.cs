using UnityEngine;
using System.Collections.Generic;



public class MasterCharacterFactory : BaseCharacterFactory
{
    [Header("All possible characters in a list")]
    [SerializeField] private List<CharacterData> allCharacterData;
    private Dictionary<CharacterData, GameObject> prefabLookup;
    /*
    MASTER CHARACTER FACTORY WILL CONTAIN A LIST OF CHARACTER DATA(SCRIPTABLE OBJECT)
    FOR FIRST TIME IT WILL MAKE A KVP MAP IN DICTIONARY FOR O(1)
    */

    void Awake()
    {   
        prefabLookup = new Dictionary<CharacterData, GameObject>();
        foreach(var characterData in allCharacterData)
        {
            prefabLookup[characterData] = characterData.characterPrefab;
        }
    }

    // CAN CREATE CHARACTER BY PASSED SPECIFIC SCRIPTABLE OBJECT
    public ICharacter CreateCharacterFromData(CharacterData data)
    {
        if(prefabLookup.TryGetValue(data, out GameObject prefab))
        {
            GameObject characterObj = Instantiate(prefab);
            UniversalCharacter unit = characterObj.GetComponent<UniversalCharacter>();
            
            if(unit != null)
            {
                unit.characterData = data;
                return unit; 
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