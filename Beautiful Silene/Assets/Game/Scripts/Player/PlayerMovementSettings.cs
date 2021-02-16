using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerMovementSettings : ScriptableObject
{
    [Header("Mouse Settings")]
    public float mouseSensitivity = 90f;

    [Header("Movement settings")]
    public float speed;
    public float gravity;
    public float jumpHeight;

    public float toGroundDistance;
    public LayerMask groundMask;

    public Vector3 velocity;
    public bool IsGrounded;
}
