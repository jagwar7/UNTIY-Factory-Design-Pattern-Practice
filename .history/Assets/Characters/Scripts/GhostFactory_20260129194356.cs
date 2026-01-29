using UnityEngine;


public class GhostFactory : BaseCharacterFactory
{
    [SerializeField] private CharacterData ghostData;
    [SerializeField] private GameObject ghostPrefab;
    public override ICharacter CreateCharacter()
    {
        GameObject ghostObj = Instantiate(ghostData.characterPrefab);
        ICharacter character = ghostObj.GetComponent<ICharacter>();
        return character;
    }
}