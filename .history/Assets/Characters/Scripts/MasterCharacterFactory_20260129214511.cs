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
        foreach(var characterData in allCharacterData)
        {
            
        }
    }

    public override ICharacter CreateCharacter()
    {
        foreach(var characterData in allCharacterData)
        {
            if(characterData.name == "Zombie X")
            {
                
            }
        }
    }
}