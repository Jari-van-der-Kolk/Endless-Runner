using UnityEngine;        using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Properties")]
    public float speed;

    [Header("References")]
    public Rigidbody2D rb;
    public Grounded ground;
    public Animator animator;

    Health health;


    private void Start()
    {
        health = GetComponent<Health>();
    }
    void Update()
    {
        GetPosition();

        if (Input.GetKeyDown(KeyCode.Space) && ground.isGrounded == true)

        {
            rb.AddForce(new Vector2(0f, 10f), ForceMode2D.Impulse);
        }
        if (health.currentHealth <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }

    void FixedUpdate()
    {
        float inputX = Input.GetAxisRaw("Horizontal");

        animator.SetFloat("Horizontal", inputX);

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
