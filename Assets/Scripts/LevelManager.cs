using UnityEngine;
using Cinemachine;


namespace Game.Core
{
    public class LevelManager : MonoBehaviour
    {
        [SerializeField] private MasterCharacterFactory masterCharacterFactory;
        [SerializeField] private CharacterData playerData;
        [SerializeField] private  CinemachineVirtualCamera virtualCamera;

        void Start()
        {
            // SPAWN ALL ENEMIES...
            masterCharacterFactory.SpawnAllEnimies();

            // SPAWN PLAYER AND ENABLE HIS PLAYER MOVEMENT SCRIPT TO CONTROL HIM
            if(playerData != null && playerData.characterPrefab != null){}
            {
                GameObject playerObj = Instantiate(playerData.characterPrefab);
                playerObj.transform.position = playerData.spawnPoint;
                playerObj.GetComponent<PlayerMovement>().enabled = true;

                if(virtualCamera != null)
                {
                    virtualCamera.Follow = playerObj.transform;
                    virtualCamera.LookAt = playerObj.transform;
                }
            }
        }

    }
}
