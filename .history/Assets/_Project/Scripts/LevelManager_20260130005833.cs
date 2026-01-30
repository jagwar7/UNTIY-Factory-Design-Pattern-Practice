using UnityEngine;
using System;
using System.Collections.Generic;


namespace Project.Core
public class LevelManager : MonoBehaviour
{
    [SerializeField] private MasterCharacterFactory masterCharacterFactory;
    [SerializeField] private CharacterData characterToSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCharacter();
        }
    }

    void SpawnCharacter()
    {
        if(masterCharacterFactory != null && characterToSpawn != null)
        {
            ICharacter spawnedCharacter = masterCharacterFactory.CreateCharacterFromData(characterToSpawn);

            if(spawnedCharacter != null)
            {
                spawnedCharacter.PerformAction();
            }
        }
    }
}