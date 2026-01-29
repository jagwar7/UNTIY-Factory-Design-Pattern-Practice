using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Factory/Character Data")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public GameObject characterPrefab; 
    public int health;
    public float speed;
    public string actionText;
}