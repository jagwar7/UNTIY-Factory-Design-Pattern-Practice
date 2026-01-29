using UnityEngine;


public class GenericCharacterFactory : BaseCharacterFactory
{
    [Header("Configuration")]
    [SerializeField] private CharacterData characterData;

    public override ICharacter CreateCharacter()
    {
        throw new System.NotImplementedException();
    }
}