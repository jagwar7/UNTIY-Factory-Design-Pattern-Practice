using UnityEngine;


public abstract class BaseCharacterFactory : MonoBehaviour
{
    public abstract ICharacter CreateCharacter();
}