using UnityEngine;


namespace Game.Core
{
    public class UniversalCharacter : MonoBehaviour, ICharacter
    {
        [Header("Assign character data scriptable object")]
        public CharacterData characterData; 
        private IWeapon currentWeapon;


        public void Initialize(CharacterData characterData)
        {
            this.characterData = characterData;
            SetupWeapon();

            Debug.Log($"==== UNIVERSAL CHARACTER === : {this.characterData}");
        }

        
        public void SetupWeapon()
        {
            if(characterData.defaultWeapon != null)
            {
                GameObject weaponObject = Instantiate(characterData.defaultWeapon.weaponPrefab, transform);
                currentWeapon = weaponObject.GetComponent<IWeapon>();
            }
        }


        public bool Fire()
        {
            if(currentWeapon == null) return false;
            return currentWeapon.Fire();
        }

        public bool Reload()
        {
            if(currentWeapon == null) return false;
            return currentWeapon.Reload();
        }

        
    }    
}
