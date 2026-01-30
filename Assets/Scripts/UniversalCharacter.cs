using UnityEngine;


namespace Game.Core
{
    public class UniversalCharacter : MonoBehaviour, ICharacter
    {
        public CharacterData characterData; 

        public void PerformAction()
        {
            if (characterData != null)
            {
                Debug.Log($"character name : {characterData.name} --- Character Action: {characterData.actionText}");
            }
            else
            {
                Debug.LogError($"No CharacterData assigned to {gameObject.name}!");
            }
        }
    }    
}
