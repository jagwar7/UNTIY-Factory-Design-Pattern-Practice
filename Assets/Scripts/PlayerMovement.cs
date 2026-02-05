using UnityEngine;

namespace Game.Core
{
    public class PlayerMovement : MonoBehaviour
    {
        private ICharacter characterCore;
        private float moveSpeed;
        private Rigidbody rb;
        private Vector3 inputDirection;


        void Start()
        {   
            characterCore = GetComponent<ICharacter>();
            if(GetComponent<UniversalCharacter>() != null)
            {
                moveSpeed = GetComponent<UniversalCharacter>().characterData.speed;        
            }
            rb = GetComponent<Rigidbody>();
            rb.freezeRotation = true;

            Debug.Log($"==== PLAYER MOVEMENT==== : character core:  {characterCore} ");
            Debug.Log($"==== PLAYER MOVEMENT==== : rigid body: {rb} ");
        }



        void Update()
        {
            // GETTING USER INPUT
            float moveX = Input.GetAxisRaw("Horizontal");
            float moveZ = Input.GetAxisRaw("Vertical");

            inputDirection = new Vector3(moveX, 0, moveZ).normalized;
        }

        void FixedUpdate()
        {
            MovePlayer();
        }


        private void MovePlayer()
        {
            Vector3 targetVelocity = inputDirection * moveSpeed;
            targetVelocity.y = rb.velocity.y;

            rb.velocity = targetVelocity;
            Debug.Log($"==== PLAYER MOVEMENT==== : velocity:  {rb.velocity} ");
            Debug.Log($"==== PLAYER MOVEMENT==== : target velocity: {targetVelocity} ");
        }



    }
}