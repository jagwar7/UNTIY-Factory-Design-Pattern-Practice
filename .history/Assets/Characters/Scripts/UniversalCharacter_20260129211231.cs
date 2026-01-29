using UnityEngine;

public class UniversalCharacter : MonoBehaviour , ICharacter
{

    public CharacterData characterData;

    public void PerformAction()
    {
        if (characterData != null)
        {
            // The logic is the same, but the result is unique to the Data asset
            Debug.Log($"{characterData.characterName} performs action: {characterData.actionMessage}");
        }
        else
        {
    }
}