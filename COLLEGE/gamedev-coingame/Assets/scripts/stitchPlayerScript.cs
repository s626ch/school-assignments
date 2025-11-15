using UnityEngine;
using UnityEngine.SceneManagement;

public class stitchPlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    CircleCollider2D circleCollider;
    public float speed = 4.0f;
    public float sprintMultiplier = 2.0f;
    public Animator anim;
    private Vector3 prevPos;
    public string currentSceneName;
    public float groundCheckDistance = 0.1f;
    public LayerMask groundLayer;
    private bool isGrounded;
    public float jumpForce = 10f;
    private bool canJump = true;
    private float moveInput;
    private bool isSprinting = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        circleCollider = GetComponent<CircleCollider2D>();
        currentSceneName = SceneManager.GetActiveScene().name;
    }
    // you know its good when every sample reference on google is now obsolete code
    [System.Obsolete]
    void Update()
    {
        checkGrounded();
        moveInput = Input.GetAxisRaw("Horizontal");
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded && canJump)
        {
            jumpFunc();
        }
        if (moveInput < 0)
        {
            sr.flipX = true;
        }
        else if (moveInput > 0)
        {
            sr.flipX = false;
        }
        // reload game scene
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene(currentSceneName);
        }
        isSprinting = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        updateAnimation();
    }
    [System.Obsolete]
    void FixedUpdate()
    {
        moveHorizontal();
    }
    [System.Obsolete]
    void moveHorizontal()
    {
        float currentSpeed = isSprinting ? speed * sprintMultiplier : speed;
        float targetVelocityX = moveInput * currentSpeed;
        float velocityDifference = targetVelocityX - rb.velocity.x;
        float movementForce = velocityDifference * rb.mass / Time.fixedDeltaTime;
        rb.AddForce(movementForce * Vector2.right);
        if (Mathf.Abs(rb.velocity.x) > currentSpeed)
        {
            rb.velocity = new Vector2(Mathf.Sign(rb.velocity.x) * currentSpeed, rb.velocity.y);
        }
    }
    [System.Obsolete]
    void jumpFunc()
    {
        rb.velocity = new Vector2(rb.velocity.x, 0);
        float appliedJump = isSprinting ? jumpForce * 1.25f : jumpForce;
        rb.AddForce(Vector2.up * appliedJump, ForceMode2D.Impulse);
        canJump = false;
    }
    void checkGrounded()
    {
        if (circleCollider == null) return;
        Vector2 circleCenter = (Vector2)transform.position + circleCollider.offset;
        float radius = circleCollider.radius * Mathf.Max(transform.lossyScale.x, transform.lossyScale.y);
        Vector2 rayStart = circleCenter;
        rayStart.y -= radius;
        RaycastHit2D hit = Physics2D.Raycast(rayStart, Vector2.down, groundCheckDistance, groundLayer);
        isGrounded = hit.collider != null;
        if (isGrounded && !Input.GetKey(KeyCode.Space))
        {
            canJump = true;
        }
    }
    [System.Obsolete]
    void updateAnimation()
    {
        Vector2 velocity = rb.velocity;
        if (isGrounded)
        {
            if (Mathf.Abs(velocity.x) > 0.1f)
            {
                anim.Play("move");
                anim.speed = isSprinting ? 2.5f / 4 : 1.25f / 3;
            }
            else
            {
                anim.Play("idle");
                anim.speed = 1f / 6;
            }
        }
        else
        {
            if (velocity.y > 0.1f)
            {
                anim.Play("jumpUp");
            }
            else if (velocity.y < -0.1f)
            {
                anim.Play("jumpFall");
            }
        }
    }
}