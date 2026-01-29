using UnityEngine;

public class ZombieFactory : BaseCharacterFactory
{
    [SerializeField] private CharacterData zombieData;


    public override ICharacter CreateCharacter()
    {
        GameObject zombieObj = Instantiate(zombieData.)
    }
}