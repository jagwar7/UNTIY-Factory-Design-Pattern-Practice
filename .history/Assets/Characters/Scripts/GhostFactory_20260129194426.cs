using UnityEngine;


public class GhostFactory : BaseCharacterFactory
{
    [SerializeField] private CharacterData ghostData;
    public override ICharacter CreateCharacter()
    {
        GameObject ghostObj = Instantiate(ghostData.characterPrefab);
        return ghostObj.GetComponent<ICharacter>();
    }
}