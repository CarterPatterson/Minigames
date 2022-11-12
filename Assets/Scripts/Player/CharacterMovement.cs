using System;
using UnityEngine;

namespace Player
{
    public class CharacterMovement : MonoBehaviour
    {
        private Rigidbody rigidbody;
        
        public float movementSpeed;

        private void Awake()
        {
            rigidbody = gameObject.GetComponent(typeof(Rigidbody)) as Rigidbody;
        }

        private void Update()
        {
            var velocity = new Vector3(0, 0, 0);
            
            if (Input.GetKey(KeyCode.W))
            {
                velocity.z += 1;
            }
            
            if (Input.GetKey(KeyCode.S))
            {
                velocity.z -= 1;
            }
            
            if (Input.GetKey(KeyCode.A))
            {
                velocity.x -= 1;
            }
            
            if (Input.GetKey(KeyCode.D))
            {
                velocity.x += 1;
            }

            rigidbody.AddForce(velocity * movementSpeed);
        }
    }
}
