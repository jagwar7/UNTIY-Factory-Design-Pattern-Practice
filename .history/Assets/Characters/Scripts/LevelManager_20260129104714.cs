using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [SerializeField] private BaseCharacterFactory characterFactory;

    void Start()
    {
        if(characterFactory != null)
        {
            ICharacter character = characterFactory.CreateCharacter();
            character
        }
    }
}