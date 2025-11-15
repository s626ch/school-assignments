using UnityEngine;
using UnityEngine.SceneManagement;
// this script is for the ship control
public class shipScript : MonoBehaviour
{
    // headers make it look cooler in the inspector, also helps for organization
    [Header("general movement settings")]
    public float moveForce = 10f;
    public float rotationTorque = 5f;
    public float brakeForce = 8f;
    public float maxSpeed = 8f;
    public float maxRotationSpeed = 180f;
    [Header("ship drag settings")]
    public float linearDamping = 0.5f;
    [Header("projectile settings")]
    public GameObject firedProj;
    public float projForce = 1.0f;
    public float projSpawnOffset = 1.0f;
    [Header("camera offset for screen wrap")]
    public float cameraOffset = 1f;
    float cameraHeight;
    float cameraWidth;
    private Rigidbody2D rb;
    private float moveInput;
    private float rotationInput;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get camera size to handle spawning the objects slightly outside the game frame
        Camera mainCamera = Camera.main;
        cameraHeight = mainCamera.orthographicSize; // ortho size for height
        cameraWidth = cameraHeight * mainCamera.aspect; // use aspect for width
        cameraHeight += cameraOffset; // add offset
        cameraWidth += cameraOffset; // ditto
        rb = GetComponent<Rigidbody2D>();
        rb.linearDamping = linearDamping;
        rb.angularDamping = 0f; // there *was* damping, but it felt...horrible to control
    }

    // Update is called once per frame
    void Update()
    {
        // get input, vert for w/s/up/down, horiz for a/d/left/right
        moveInput = Input.GetAxisRaw("Vertical");
        rotationInput = Input.GetAxisRaw("Horizontal");
        handleScreenWrap();
        handleProjectiles();
        if (rotationInput == 0f && rb.angularVelocity != 0f)
        {
            rb.angularVelocity = 0f;
        }
    }
    void FixedUpdate()
    {
        handleMovement();
        handleRotation();
        clampVelocity();
        clampRotationVelocity();
    }
    void handleMovement()
    {
        if (moveInput > 0f) // w/up, forward movement
        {
            rb.AddForce(transform.up * moveForce * moveInput);
        }
        else if(moveInput<0f) // s/down, braking
        {
            if(rb.linearVelocity.magnitude > 0.1f)
            {
                Vector2 brakeDirection = -rb.linearVelocity.normalized;
                rb.AddForce(brakeDirection * brakeForce * Mathf.Abs(moveInput));
            }
        }
    }
    void handleRotation()
    {
        if(rotationInput != 0f) // a/d/left/right, rotation
        {
            rb.AddTorque(-rotationInput * rotationTorque);
        }
    }
    void clampVelocity()
    {
        if (rb.linearVelocity.magnitude > maxSpeed) // limit max speed
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
    }
    void clampRotationVelocity()
    {
        if (Mathf.Abs(rb.angularVelocity) > maxRotationSpeed) // limit how fast you can spin
        {
            rb.angularVelocity = Mathf.Sign(rb.angularVelocity) * maxRotationSpeed;
        }
    }
    void handleScreenWrap()
    {
        float currX = transform.position.x;
        float currY = transform.position.y;
        float currZ = transform.position.z;
        if (currY < -cameraHeight) // flip your y for bottom/top
        {
            transform.position = new Vector3(currX, -(currY + 0.5f) , currZ);
        }
        if(currY > cameraHeight)
        {
            transform.position = new Vector3(currX, -(currY - 0.5f), currZ);
        }
        if (currX < -cameraWidth)
        {
            transform.position = new Vector3(-(currX + 0.5f), currY, currZ);
        }
        if (currX > cameraWidth)
        {
            transform.position = new Vector3(-(currX - 0.5f), currY, currZ);
        }
    }
    void handleProjectiles()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            GameObject p = Instantiate(firedProj, transform.position + transform.up * projSpawnOffset, transform.rotation);
            Rigidbody2D prb = p.GetComponent<Rigidbody2D>();
            prb.linearVelocity = rb.linearVelocity;
            prb.AddRelativeForce(new Vector2(0, projForce), ForceMode2D.Impulse);
        }
    }
}
