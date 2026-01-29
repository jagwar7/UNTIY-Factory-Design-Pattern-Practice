using UnityEngine;
using System;
using System.Collections.Generic;


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
            
        }
    }
}