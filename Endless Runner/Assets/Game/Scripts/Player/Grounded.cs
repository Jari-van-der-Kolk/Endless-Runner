using UnityEngine;

public class Grounded : MonoBehaviour
{
    public bool isGrounded;
    public LayerMask whatIsGround;

    private void Update()
    {
        if (Physics2D.Raycast(transform.position, Vector2.down * 2, 0.01f, whatIsGround))
        {
            isGrounded = true;
        }
        else
        {
            isGrounded = false;
        }
       
    }
}
