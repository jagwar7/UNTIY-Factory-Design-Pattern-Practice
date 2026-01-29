using UnityEngine;
using System;
using System.co


public class LevelManager : MonoBehaviour
{
    [Header("List of character Factory")]
    [SerializeField] private List<BaseCharacterFactory> characterFactoryList;

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