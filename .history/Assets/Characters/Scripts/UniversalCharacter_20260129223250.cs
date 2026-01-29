using UnityEngine;

public class UniversalCharacter : MonoBehaviour , ICharacter
{

    /*
    ----------------------------------------------------------
    REFERANCE OF CHARACTER DATA IS REQUIRED TO PERFORM 

    ----------------------------------------------------------

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