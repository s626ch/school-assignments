using UnityEngine;

public class screenWrap : MonoBehaviour
{
    // originally this was to handle wrapping objects from top/bottom/left/right
    // ...but it sucked, so each object now has its own handling in a wrapHandler script*
    // *: the spaceship handles wrapping in the control script
    // this script (and parent manager) handles containing the missiles
    [Header("only one of these should be checked at a time")]
    public bool isHoriz;
    public bool isVert;
    [Header("height and width offset to make colliders cover eachother")]
    public float cameraOffset = 1f;
    [Header("configurable tags")]
    public string projectileTag = "missile";
    public string enemProjTag = "enemyMissile";
    public string rockTag = "asteroid";
    float cameraHeight;
    float cameraWidth;
    // we need to store the width and height for the collision boxes since we're only manipulating one axis at a time
    Vector3 currentScale;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get camera size to handle spawning the objects slightly outside the game frame
        Camera mainCamera = Camera.main;
        cameraHeight = mainCamera.orthographicSize; // ortho size for height
        cameraWidth = cameraHeight * mainCamera.aspect; // use aspect for width
        cameraHeight += cameraOffset; // add offset
        cameraWidth += cameraOffset; // ditto
        // get size of preset prefab
        currentScale = transform.localScale;
        handleObjectManip();
    }
    void handleObjectManip()
    {
        // prefabs will start as a set size, here is where actual manipulation on the size occurs
        if (isHoriz)
        {
            currentScale.x = cameraWidth * 2; // x2 because scaling is both ways and centered
            transform.localScale = currentScale;
        }
        if (isVert) {
            currentScale.y = cameraHeight * 2;
            transform.localScale = currentScale;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject rcv = collision.gameObject;
        if (rcv.CompareTag(projectileTag) || rcv.CompareTag(rockTag) || rcv.CompareTag(enemProjTag))
        {
            Destroy(rcv);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
