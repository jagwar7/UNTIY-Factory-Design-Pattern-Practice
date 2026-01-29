using UnityEngine;
using System.Collections.Generic;


public class MasterCharacterFactory : BaseCharacterFactory
{
    [Header("All possible characters in a list")]
    [SerializeField] private List<CharacterData> allCharacterData;


    public override ICharacter CreateCharacter()
    {
        throw new System.NotImplementedException();
    }
}