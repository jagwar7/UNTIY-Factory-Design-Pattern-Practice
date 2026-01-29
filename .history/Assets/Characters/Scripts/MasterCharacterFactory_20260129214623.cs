using UnityEngine;
using System.Collections.Generic;


public class MasterCharacterFactory : BaseCharacterFactory
{
    [Header("All possible characters in a list")]
    [SerializeField] private List<CharacterData> allCharacterData;
    private Dictionary<CharacterData, GameObject> prefabLookup;
    /*
    OBJECT TYPE KEY IS EFFICIENT THAN STRING
    */

    void Awake()
    {   
        prefabLookup = new Dictionary<CharacterData, GameObject>();
        foreach(var characterData in allCharacterData)
        {
            prefabLookup[characterData] = characterData.characterPrefab;
        }
    }

    public override ICharacter CreateCharacter()
    {
        
    }

}