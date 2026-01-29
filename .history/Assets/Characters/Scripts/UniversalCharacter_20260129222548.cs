using UnityEngine;

public class UniversalCharacter : MonoBehaviour , ICharacter
{

    /*
    -----------------COMMENTS--------------------


    -----------------COMMENTS--------------------

    */

    public CharacterData characterData;

    public void PerformAction()
    {
        if (characterData != null)
        {
            Debug.Log($"{characterData.characterName} performs action: {characterData.actionText}");
        }
        else
        {
            Debug.LogError($"No CharacterData assigned to {gameObject.name}!");
        }
    }
}