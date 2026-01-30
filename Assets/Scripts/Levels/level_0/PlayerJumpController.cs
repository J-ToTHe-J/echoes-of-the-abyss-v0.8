using UnityEngine;

public class PlayerJumpController : MonoBehaviour
{
    [SerializeField] private float jumpForce; // Adjustable jump force
    private Rigidbody2D body;
    private Animator anim;
    private bool grounded;

    private void Awake()
    {
        // Grabs references for Rigidbody2D and Animator from the GameObject
        body = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    private void Update()
{
    // Check for jump using the "Jump" action
    if (Input.GetKeyDown(KeyCode.JoystickButton0) && grounded)
    {
        Jump();
    }
}

    private void Jump()
    {
        body.velocity = new Vector2(body.velocity.x, jumpForce);
        anim.SetTrigger("jump");
        grounded = false;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            grounded = true;
        }
    }
}
