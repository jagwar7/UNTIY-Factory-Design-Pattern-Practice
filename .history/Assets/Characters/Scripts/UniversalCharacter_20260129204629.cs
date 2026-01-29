using UnityEngine;


public class UniversalCharacter : MonoBehaviour, ICharacter
{
    // Type this exactly. If it shows a red squiggle, we will fix it in Step 2.
    public CharacterData characterData; 

    public void PerformAction()
    {
        if (characterData != null)
        {
            Debug.Log(characterData.actionMessage);
        }
    }
}