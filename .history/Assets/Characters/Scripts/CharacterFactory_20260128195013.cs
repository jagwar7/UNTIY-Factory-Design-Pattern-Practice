using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    
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
