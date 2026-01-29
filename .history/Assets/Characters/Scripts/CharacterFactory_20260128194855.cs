using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    public ICharacter CreateCharacter(string type)
    {
        if(type == "zombie")
        {
            
        }
        if(type == "ghost")
        {
            
        }
        return null;
    }
}
