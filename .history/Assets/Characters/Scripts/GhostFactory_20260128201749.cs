using UnityEngine;


public class GhostFactory : BaseCharacterFactory
{
    [SerializeField] private GameObject ghostPrefab;
    public override ICharacter CreateCharacter()
    {
        return Instantiate(ghostPrefab)
    }
}