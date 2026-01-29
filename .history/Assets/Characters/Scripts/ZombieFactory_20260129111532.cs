using UnityEngine;

public class ZombieFactory : BaseCharacterFactory
{
    [SerializeField] private GameObject zombiePrefab;

    public override ICharacter CreateCharacter()
    {
        Debug.Log("Ghost Entered in the Game World");

        return Instantiate(zombiePrefab).GetComponent<ICharacter>();
    }
}