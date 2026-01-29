using UnityEngine;

public class ZombieFactory : BaseCharacterFactory
{
    [SerializeField] private CharacterData zombieData
    [SerializeField] private GameObject zombiePrefab;

    public override ICharacter CreateCharacter()
    {
        Debug.Log("Zombie Entered in the Game World");

        return Instantiate(zombiePrefab).GetComponent<ICharacter>();
    }
}