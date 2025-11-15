using UnityEngine;

public class ProjectileHit : MonoBehaviour
{
    public GameObject explosion; // Animation to generate
    public string tagname = "Target"; // Destroy anything with this tag

    void OnCollisionEnter2D(Collision2D collision)
    {
        // Only destroy targets
        GameObject g = collision.gameObject;
        if (g.CompareTag(tagname))
        {
            // If hit target, destroy it
            GameObject.Destroy(g);
        }

        // Generate explosion animation prefab and destroy immediately
        GameObject e = Instantiate(explosion, transform.position, transform.rotation);
        GameObject.Destroy(e, 0.5f);

        // Destroy self when hit anything
        GameObject.Destroy(this.gameObject);
    }
}
