using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacter", menuName = "Factory/Character Data")]
public class CharacterData : ScriptableObject {
    public string characterType;
    public GameObject characterPrefab; // Your 3D Model
    public float moveSpeed;
}