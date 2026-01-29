using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    public ICharacter CreateCharacter(string type)
    {
        GameObject characterInstance;
        
        if(type == "zombie")
        {
            
        }
        if(type == "ghost")
        {
            
        }
        return null;
    }
}
