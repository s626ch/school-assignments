using UnityEngine;

public class enemyIntelligence : MonoBehaviour
{
    [Header("interval settings")]
    public float shootInterval = 1f;
    public float moveInterval = 1f;
    [Header("random chance to make the enemies look smart")]
    public float shootChance = 25f;
    public float randomMoveChance = 25f;
    [Header("projectile settings")]
    public GameObject enemyMissilePrefab;
    public float projForce = 1.0f;
    public float projSpawnOffset = 1.0f;
    [Header("speed settings")]
    public float minMoveForce = 1f;
    public float maxMoveForce = 10f;
    public float maxSpeed = 8f;
    public float linearDamping = 0.5f;
    [Header("aim settings")]
    public string playerTag = "Player";
    public float rotationOffset = -90f;
    public float rotationSpeed = 200f;
    private Transform player;
    private Rigidbody2D rb;
    private float moveTimer = 0f;
    private float shootTimer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearDamping = linearDamping;
        GameObject playerObject = GameObject.FindGameObjectWithTag(playerTag);
        if(playerObject != null)
        {
            player = playerObject.transform;
        }
    }

    // Update is called once per frame
    void Update()
    {
        handleRandomMovement();
        handleRandomShooting();
    }
    void FixedUpdate()
    {
        if (player != null)
        {
            aimTowardsPlayer();
        }
        clampVelocity();
    }
    void handleRandomMovement()
    {
        moveTimer += Time.deltaTime;
        if (moveTimer >= moveInterval)
        {
            float randomChance = Random.Range(0f, 100f);
            if (randomChance <= randomMoveChance)
            {
                float driftForce = Random.Range(minMoveForce, maxMoveForce);
                Vector2 driftDirection = Random.insideUnitCircle.normalized; // a completely random direction from inside a 1.0 radii circle
                rb.AddForce(driftDirection * driftForce, ForceMode2D.Impulse);
            }
            moveTimer = 0f;
        }
    }
    void handleRandomShooting()
    {
        shootTimer += Time.deltaTime;
        if (shootTimer >= shootInterval)
        {
            float randomChance = Random.Range(0f, 100f);
            if (randomChance <= shootChance)
            {
                GameObject p = Instantiate(enemyMissilePrefab, transform.position + transform.up * projSpawnOffset, transform.rotation);
                Rigidbody2D prb = p.GetComponent<Rigidbody2D>();
                prb.linearVelocity = rb.linearVelocity;
                prb.AddRelativeForce(new Vector2(0, projForce), ForceMode2D.Impulse);
            }
            shootTimer = 0f;
        }
    }
    void clampVelocity()
    {
        if (rb.linearVelocity.magnitude > maxSpeed) // limit max speed
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
        }
    }
    void aimTowardsPlayer()
    {
        Vector2 direction = player.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg + rotationOffset;
        rb.MoveRotation(Mathf.LerpAngle(rb.rotation, angle, rotationSpeed * Time.fixedDeltaTime));
    }
}
