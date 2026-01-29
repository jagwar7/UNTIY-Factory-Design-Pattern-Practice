using UnityEngine;


public class LevelManager : MonoBehaviour
{
    [Header("List of character Factory")]
    [SerializeField] private List<BaseCharacterFactory> charc

    void Start()
    {
        if(zombieFactory != null)
        {
            ICharacter character = zombieFactory.CreateCharacter();
            character.PerformAction();
        }
        if(ghostFactory != null)
        {
            ICharacter character = zombieFactory.CreateCharacter();
            character.PerformAction();
        }
    }
}