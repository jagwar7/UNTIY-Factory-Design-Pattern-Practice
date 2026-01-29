using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [Header("Specific Factories")]
    [SerializeField] private BaseCharacterFactory zombieFactory;
    [SerializeField] private BaseCharacterFactory ghostFactory;

    void Start()
    {
        if(zombief != null)
        {
            ICharacter character = zombief.CreateCharacter();
            character.PerformAction();
        }
    }
}