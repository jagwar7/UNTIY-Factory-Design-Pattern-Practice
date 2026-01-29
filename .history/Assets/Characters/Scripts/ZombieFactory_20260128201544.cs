using UnityEngine;

public class ZombieFactory :  BaseCharacterFactory
{
    [SerializeField] private GameObject zombiePrefab;

    public override ICharacter CreateCharacter()
    {
        return Instantiate(zombiePrefab).GetComponent<ICharacter>();
    }
}