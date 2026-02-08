using UnityEngine;


namespace Game.Core
{
    public class RaycastWeapon : MonoBehaviour, IWeapon
    {   
        [Header("Assign weapon data scriptable object")]
        [SerializeField] WeaponData weaponData;

        private int currentAmmo;
        private float lastFireTime;

        private void Awake()
        {
            if(weaponData != null) currentAmmo = weaponData.maxAmmo;
        }


        
        public bool Fire()
        {
            if(currentAmmo > 0 && Time.time >= lastFireTime + weaponData.fireRate)
            {
                currentAmmo--;
                lastFireTime = Time.time;
                return true;
            }

            return false;
        }

        public bool Reload()
        {
            if(weaponData == null) return false;

            currentAmmo = weaponData.maxAmmo;
            return true;
        }
    }
}