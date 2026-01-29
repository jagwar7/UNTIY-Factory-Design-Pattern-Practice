using UnityEngine;

[CreateAssetMenu(fileName = "NewCharacterData", menuName = "Factory/Character Data")]public class characterData : ScriptableObject
{
    public string CharacterName;
    public int health;
    public GameObject characterPrefab;
}