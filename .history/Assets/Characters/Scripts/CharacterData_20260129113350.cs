using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Factory/Character Data")]
public class CharacterData : ScriptableObject
{
    public string characterName;
    public GameObject characterPrefab; // The 3D Game Object
    public int health;
    public float speed;
}