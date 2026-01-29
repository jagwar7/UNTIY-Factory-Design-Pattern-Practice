using UnityEngine;

public class ZombieFactory : BaseCharacterFactory
{
    [SerializeField] private CharacterData zombieData;


    public override ICharacter CreateCharacter()
    {
        Debug.Log("Zombie Entered in the Game World");

        return Instantiate(zombiePrefab).GetComponent<ICharacter>();
    }
}