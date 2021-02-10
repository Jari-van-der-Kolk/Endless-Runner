using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Properties")]
    public float speed;

    [Header("References")]
    public Rigidbody2D rb;
    public Grounded ground;

    void Update()
    {
        GetPosition();

        if (Input.GetKeyDown(KeyCode.Space) && ground.isGrounded == true)

        {
            rb.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        }
    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        Vector2 movement = new Vector2(inputX * speed, -3);
        movement *= Time.fixedDeltaTime;

        transform.Translate(movement);

        //if (inputX == 0 && ground.isGrounded == true)
        //{
        //    // freeze position
        //}
    }
    public Vector3 GetPosition() => transform.position;
}
