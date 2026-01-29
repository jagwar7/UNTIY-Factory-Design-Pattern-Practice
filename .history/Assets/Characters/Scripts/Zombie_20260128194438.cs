using UnityEngine;

public class Zombie : MonoBehaviour, ICharacter
{
    public void PerformAction() => Debug.Log("The Zombie groans: 'Brans...'")
}
