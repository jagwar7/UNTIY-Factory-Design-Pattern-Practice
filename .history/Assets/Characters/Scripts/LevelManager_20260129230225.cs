using UnityEngine;
using System;
using System.Collections.Generic;


public class LevelManager : MonoBehaviour
{
    [SerializeField] private MasterCharacterFactory masterCharacterFactory;
    [SerializeField] private CharacterData characterDataToSpawn;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpawnCharacter();
        }
    }

    
}