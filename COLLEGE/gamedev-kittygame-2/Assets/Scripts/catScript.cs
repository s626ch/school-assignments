using UnityEngine;
using UnityEngine.Rendering;

public class catScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    Vector2 del;
    private Vector3 prevPos;
    public float speed = 1.0f;
    public float stopProximity = 0.25f;
    public string targetTag = "Player"; // tag of target to run away from
    Rigidbody2D grb;
    GameObject g;
    GameObject chaseTimer;
    public Animator anim;
    /*
    GameObject g = GameObject.FindWithTag(targetTag);
    grb = g.GetComponent<Rigidbody2D>();
    */
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
            // dont move if the distance to target is below the proximity
            if (del.magnitude > stopProximity)
            {
                del.Normalize();
                if (chaseTimer != null)
                {
                    rb.position += del * speed * Time.deltaTime;
                }
                else
                {
                    rb.position -= del * speed * Time.deltaTime;
                }
            }
        }
        // stop cats walking if the player isnt present
        if(g==null)
        {
            anim.Play("walk", 0, 0f);
            anim.speed = 0;
            //Destroy(anim);
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
}
