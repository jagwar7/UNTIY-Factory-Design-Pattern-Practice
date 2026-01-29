using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [Header("Specific Factories")]
    [SerializeField] private BaseCharacterFactory zombieFactory;
    [SerializeField] private BaseCharacterFactory ghostFactory;

    void Start()
    {
        if(zombieFactory != null)
        {
            ICharacter character = zombieFactory.CreateCharacter();
            character.PerformAction();
        }
        if(zombieFactory != null)
        {
            ICharacter character = zombieFactory.CreateCharacter();
            character.PerformAction();
        }
    }
}