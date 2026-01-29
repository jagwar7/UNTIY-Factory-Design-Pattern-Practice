using UnityEngine;

public class CharacterFactory : MonoBehaviour
{
    [SerializeField] private GameObject zombiePrefab;
    [SerializeField] private GameObject ghostPrefab;


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
