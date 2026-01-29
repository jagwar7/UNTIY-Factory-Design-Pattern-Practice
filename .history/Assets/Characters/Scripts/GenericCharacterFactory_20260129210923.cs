using UnityEngine;


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


        GameObject characterObj = Instantiate(characterData.characterPrefab);
        UniversalCharacter unitScript = characterObj.GetComponent<UniversalCh

        return characterObj.GetComponent<ICharacter>();
    }
}