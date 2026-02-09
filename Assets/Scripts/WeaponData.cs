using UnityEngine;


namespace Game.Core
{
    [CreateAssetMenu(fileName = "NewWeaponData", menuName = "Factory/Weapon Data")]
    public class WeaponData : ScriptableObject
    {
        [Header("Visuals")]
        public string weaponName;
        public GameObject weaponPrefab;

        [Header("Settings")]
        public int damage;
        public int maxAmmo;
        public int AmmoCapacity;
        public int reloadAmmo;
        public float fireRate;
        public float range;
    }
}