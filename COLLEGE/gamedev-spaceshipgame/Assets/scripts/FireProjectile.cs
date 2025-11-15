using UnityEngine;

public class FireProjectile : MonoBehaviour
{
    public GameObject projectile; // What I am firing
    public float force = 1.0f; // Impulse force to fire it
    public float offset = 1.0f; // How far in front to instantiate it
    Rigidbody2D rb; // My physics component (need for initial velocity)

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Instantiate at my location and facing same way as me
            // Plus offset in local y direction
            GameObject p = Instantiate(projectile,
                              transform.position + transform.up * offset,
                              transform.rotation);

            // Get its physics component and add local force
            Rigidbody2D prb = p.GetComponent<Rigidbody2D>();

            // Can match velocity to mine before adding firing force
            prb.linearVelocity = rb.linearVelocity;

            // Add local force in facing direction
            prb.AddRelativeForce(new Vector2(0, force), ForceMode2D.Impulse);

            // Destroy after some reasonable amount of time
            GameObject.Destroy(p, 10);
        }
    }
}
