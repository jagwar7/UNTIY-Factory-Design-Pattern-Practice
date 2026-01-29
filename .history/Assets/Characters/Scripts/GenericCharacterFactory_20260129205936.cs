using System.Data.Common;
using UnityEngine;
using UnityEngine.TextCore.Text;


public class GenericCharacterFactory : BaseCharacterFactory
{
    [Header("Configuration")]
    [SerializeField] private CharacterData characterData;

    public override ICharacter CreateCharacter()
    {
        if(characterData == null || characterData.characterPrefab == null)
        {
            Debug.LogError($"Factory on game object {gameObject.name} is missing data !");
            return null;
        }

        UniversalChar

        GameObject characterObj = Instantiate(characterData.characterPrefab);
        return characterObj.GetComponent<ICharacter>();
    }
}