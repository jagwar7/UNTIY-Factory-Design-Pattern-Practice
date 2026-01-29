using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    []
    public ICharacter CreateCharacter(string type)
    {
        GameObject characterInstance;

        if(type == "zombie")
        {
            // characterInstance  = Instantiate()
        }
        if(type == "ghost")
        {
            
        }
        return null;
    }
}
