using UnityEngine;
using UnityEngine.SceneManagement;

public class stitchPlayerScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    public float speed = 1.0f;
    float playerSpeed;
    public float sprintMultiplier = 2.0f;
    float dx, dy;
    public Animator anim;
    private Vector3 prevPos;
    public GameObject prefab;
    public string currentSceneName;
    GameObject useTimer; GameObject chaseTimer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim.Play("idle");
        currentSceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        // find timer monitor empties
        useTimer = GameObject.FindWithTag("UseObj");
        chaseTimer = GameObject.FindWithTag("Chase");
        dx = 0; dy = 0;
        // ==============================================================
        // ==================== BEGIN MOVEMENT KEYS =====================
        // ==============================================================
        if (Input.GetKey("w") || Input.GetKey(KeyCode.UpArrow))
        {
            dy = playerSpeed * Time.deltaTime;
            anim.Play("walk");
        }
        if (Input.GetKey("s") || Input.GetKey(KeyCode.DownArrow))
        {
            dy = -playerSpeed * Time.deltaTime;
            anim.Play("walk");
        }
        if (Input.GetKey("a") ||  Input.GetKey(KeyCode.LeftArrow))
        {
            dx = -playerSpeed * Time.deltaTime;
            sr.flipX = true;
            anim.Play("walk");
        }
        if (Input.GetKey("d") || Input.GetKey(KeyCode.RightArrow))
        {
            dx = playerSpeed * Time.deltaTime;
            sr.flipX = false;
            anim.Play("walk");
        }
        // ==============================================================
        // ==================== END OF MOVEMENT KEYS ====================
        // ==============================================================
        // call the cats
        if (Input.GetKeyDown("e") && useTimer == null && chaseTimer == null)
        {
            GameObject insObj = Instantiate(prefab, transform);
        }
        // reload game scene
        if (Input.GetKeyDown("p"))
        {
            SceneManager.LoadScene(currentSceneName);
        }
        // running
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            playerSpeed = speed * sprintMultiplier;
            anim.speed = 1.5f;
        } else { playerSpeed = speed; anim.speed = 0.75f; }
        rb.position += new Vector2(dx, dy);
    }
    void FixedUpdate()
    {
        // fixed update monitor for direction and flipping the sprite according to movement direction
        Vector3 movementDir = (transform.position - prevPos).normalized;
        if (movementDir.x > 0)
        {
            sr.flipX = false;
        }
        if (movementDir.x < 0)
        {
            sr.flipX = true;
        }
        if (movementDir.x == 0 && movementDir.y == 0)
        {
            anim.Play("idle");
        }
        prevPos = transform.position;
    }
}
