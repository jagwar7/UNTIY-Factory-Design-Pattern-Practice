using UnityEngine;


public class GhostFactory : BaseCharacterFactory
{
    [SerializeField] private GameObject ghostPrefab;
    public override ICharacter CreateCharacter()
    {
        Debug.Log()
        return Instantiate(ghostPrefab).GetComponent<ICharacter>();
    }
}