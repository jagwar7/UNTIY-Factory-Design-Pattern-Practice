using UnityEngine;
using System.Collections.Generic;


namespace Game.Core
{
    public class MasterCharacterFactory : BaseCharacterFactory
    {
        [Header("Add character data scriptable objects to this list")]
        [SerializeField] private List<CharacterData> allCharacterData;
        private Dictionary<CharacterData, GameObject> prefabLookup;



        /*  --------------------------------------------------------------------------------------
            MASTER CHARACTER FACTORY WILL CONTAIN A LIST OF CHARACTER DATA(SCRIPTABLE OBJECT)
            FOR FIRST TIME IT WILL MAKE A KVP MAP IN DICTIONARY FOR O(1) LOOKUP
            USED CHARACTER OBJECT AS KEY INSTEAD OF STRING BECAUSE OF EFFICIENT HASHING SPEED

            THE LIST OF SCRIPTABLE OBJECT IS A SINGLE SOURCE OF TRUTCH, ITS IN FUTURE IF WE WANT TO
            RENDER ALL THE ITEMS TO THE UI (FOR A SCROLLABLE LIST) THEN WE DONT NEED TO CREATE A
            SEPAREATE LIST TO RENDER ITEMS , WE CAN USE THE EXISTING LIST TO RENDER ITEMS ON UI
            --------------------------------------------------------------------------------------
        */

        void Awake()
        {   
            prefabLookup = new Dictionary<CharacterData, GameObject>();
            foreach(var characterData in allCharacterData)
            {
                prefabLookup[characterData] = characterData.characterPrefab;
            }
        }





        /*
            CHARACTER WILL BE SPAWNED FROM FACTORY ---> PLACED IN THEIR CORRESPONDING POSITION
        */
        // public ICharacter CreateCharacterFromData(CharacterData data)
        // {
        //     if(prefabLookup.TryGetValue(data, out GameObject prefab))
        //     {
        //         GameObject characterObj = Instantiate(prefab);
        //         UniversalCharacter characterUnit = characterObj.GetComponent<UniversalCharacter>();
        //         characterObj.transform.position = data.spawnPoint;
                
                
        //         if(characterUnit != null)
        //         {
        //             characterUnit.Initialize(data); // PASS CHARCTER DATA TO CHARACTER
        //             return characterUnit; 
        //         }
        //     }
        //     return null;
        // }



        public override ICharacter CreateCharacter(CharacterData data) 
        {
            if(prefabLookup.TryGetValue(data, out GameObject prefab))
            {
                GameObject characterObj = Instantiate(prefab);
                UniversalCharacter characterUnit = characterObj.GetComponent<UniversalCharacter>();
                characterObj.transform.position = data.spawnPoint;
                
                
                if(characterUnit != null)
                {
                    characterUnit.Initialize(data); // PASS CHARCTER DATA TO CHARACTER
                    return characterUnit; 
                }
            }
            return null;
        }


        public void SpawnAllEnimies()
        {
            foreach(var characterData in prefabLookup)
            {
                CreateCharacter(characterData.Key);
            }
        }
    }    
}
