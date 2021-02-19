using UnityEngine;

public class Grounded : MonoBehaviour
{
    public bool isGrounded;
    public LayerMask whatIsGround;

    private void Update()
    {
        if (Physics2D.Raycast(transform.position, Vector2.right, 1f, whatIsGround))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
       
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + Vector3.right);
    }
}
