using UnityEngine;


public class UniversalCharacter : MonoBehaviour, ICharacter
{
    public CharacterData characterData; 

    public void PerformAction()
    {
        if (characterData != null)
        {
            Debug.Log($"character name : {characterData.name} --- ");
        }
    }
}