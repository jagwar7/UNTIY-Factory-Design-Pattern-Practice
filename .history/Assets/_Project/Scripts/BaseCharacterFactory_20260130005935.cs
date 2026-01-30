using UnityEngine;

namespace Project.Core
{
    
}
public abstract class BaseCharacterFactory : MonoBehaviour
{
    public abstract ICharacter CreateCharacter();
}