using UnityEngine;

public class ZombieFactory : BaseCharacterFactory
{
    [SerializeField] private CharacterData zombieData;

    // CREATING CHARACTER FROM ZOMBIE SCRIPTABLE OBJECT
    public override ICharacter CreateCharacter()
    {
        GameObject zombieObj = Instantiate(zombieData.characterPrefab);
        return zombieObj.GetComponent<ICharacter>();
    }
}