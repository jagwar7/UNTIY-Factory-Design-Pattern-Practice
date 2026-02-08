using UnityEngine;


namespace Game.Core
{
    [CreateAssetMenu(fileName = "NewCharacterData", menuName = "Factory/Character Data")]
    public class CharacterData : ScriptableObject
    {   
        [Header("Setup")]
        public string characterName;
        public GameObject characterPrefab; 
        public int health;
        public float speed;
        public Vector3 spawnPoint;
        
        [Header("Equipment")]
        public WeaponData defaultWeapon;
    } 
}
