using System.Diagnostics;
using UnityEngine;

public class UniversalCharacter : MonoBehavior , ICharacter
{
    public CharacterData characterData;
    public void PerformAction()
    {
        if (characterData != null)
        {
            Debug.Log
        }
    }
}