using UnityEngine;
using UnityEngine.Rendering;
// this script is more or less the same as the cat script, except things are inverted
// ie, instead of moving away from the player they move towards, and when the player
// calls the cats, the enemies run away
//
// also, when collided, the enemy will "blow up" both itself and the player

public class enemyScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    Vector2 del;
    private Vector3 prevPos;
    public float speed = 1.0f;
    public float stopProximity = 0.1f;
    public string targetTag = "Player"; // tag of target to run towards
    Rigidbody2D grb;
    GameObject g;
    GameObject chaseTimer;
    public Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // get target gameobject -- ideally youd do this once and not every frame
        chaseTimer = GameObject.FindWithTag("Chase");
        g = GameObject.FindWithTag(targetTag);
        if (g != null)
        {
            grb = g.GetComponent<Rigidbody2D>();
            // distance to target in each dimension using entire position vector
            del = grb.position - rb.position;
            if (del.magnitude > stopProximity)
            {
                del.Normalize();
                if (chaseTimer != null)
                {
                    rb.position -= del * speed * Time.deltaTime;
                }
                else
                {
                    rb.position += del * speed * Time.deltaTime;
                }
            }
        } // stop enemies walking if the player isnt present, for if theres multiple on screen
        if(g == null)
        {
            anim.Play("bobOmb", 0, 0f);
            anim.speed = 0;
        }
    }
    void FixedUpdate()
    {
        Vector3 movementDir = (transform.position - prevPos).normalized;
        if (movementDir.x > 0)
        {
            sr.flipX = false;
        }
        if (movementDir.x < 0)
        {
            sr.flipX = true;
        }
        prevPos = transform.position;
    }
    // remove both enemy and player when collided with
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(targetTag))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
