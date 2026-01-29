using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [Header("Specific Factories")]
    [SerializeField] private BaseCharacterFactory zombieFactory;
    [SerializeField] private BaseCharacterFactory ghostFactory;

    void Start()
    {
        if(zombie != null)
        {
            ICharacter character = zombie.CreateCharacter();
            character.PerformAction();
        }
    }
}