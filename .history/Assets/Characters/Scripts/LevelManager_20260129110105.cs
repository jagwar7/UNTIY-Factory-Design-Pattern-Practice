using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [Header("Specific Factories")]
    [SerializeField] private BaseCharacterFactory zombieFactory;
    [SerializeField] private BaseCharacterFactory EnemyFactory;

    void Start()
    {
        if(characterFactory != null)
        {
            ICharacter character = characterFactory.CreateCharacter();
            character.PerformAction();
        }
    }
}