using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [Header("Specific factories")]
    [SerializeField] private BaseCharacterFactory characterFactory;

    void Start()
    {
        if(characterFactory != null)
        {
            ICharacter character = characterFactory.CreateCharacter();
            character.PerformAction();
        }
    }
}