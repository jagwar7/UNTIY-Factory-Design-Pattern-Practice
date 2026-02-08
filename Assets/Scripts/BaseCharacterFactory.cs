using UnityEngine;

namespace Game.Core
{
    public abstract class BaseCharacterFactory : MonoBehaviour
    {
        public abstract ICharacter CreateCharacter(CharacterData data);
    }    
}
