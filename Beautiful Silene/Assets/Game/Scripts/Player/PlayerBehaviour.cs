using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public CharacterController controller;

    
    [Header("Movement settings")]
    public float speed ;
    public float gravity;
    public float jumpHeight;

    public float toGroundDistance;
    public LayerMask groundMask;

    public Vector3 velocity;
    public bool IsGrounded;

    public Transform groundCheck;

    private void Start() {
        controller = GetComponent<CharacterController>();
    }

    private void Update() {
        IsGrounded = Physics.CheckSphere(groundCheck.position, toGroundDistance, groundMask);
        if (IsGrounded && velocity.y < 0) {
            velocity.y = -2f;
        }
    
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
    
        Vector3 move = transform.right * x + transform.forward * z;
    
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
    
        if (Input.GetButtonDown("Jump") && IsGrounded) {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    
        controller.Move(velocity * Time.deltaTime);
    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheck.position, toGroundDistance);
    }

}
