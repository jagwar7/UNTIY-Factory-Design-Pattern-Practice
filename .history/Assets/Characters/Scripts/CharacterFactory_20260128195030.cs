using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    [SerializeField] GameObject ghostPrefab
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
