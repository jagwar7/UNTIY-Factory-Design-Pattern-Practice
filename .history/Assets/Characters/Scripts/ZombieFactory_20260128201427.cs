using UnityEngine;

public class ZombieFactory : MonoBehaviour, BaseCharacterFactory
{
    [SerializeField] private GameObject zombiePrefab;

    public override ICharacter CreateCharacter()
}