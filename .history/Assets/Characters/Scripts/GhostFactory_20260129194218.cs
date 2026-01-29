using UnityEngine;


public class GhostFactory : BaseCharacterFactory
{
    [ser]
    [SerializeField] private GameObject ghostPrefab;
    public override ICharacter CreateCharacter()
    {
        Debug.Log("Ghost Entered in the Game World");
        return Instantiate(ghostPrefab).GetComponent<ICharacter>();
    }
}