using UnityEngine;


public class GhostFactory : BaseCharacterFactory
{
    [SerializeField] private CharacterData ghostData;

    // CREATING GHOST FROM GHOST SCRIPTABLE OBJECT
    public override ICharacter CreateCharacter()
    {
        GameObject ghostObj = Instantiate(ghostData.characterPrefab);
        return ghostObj.GetComponent<ICharacter>();
    }
}