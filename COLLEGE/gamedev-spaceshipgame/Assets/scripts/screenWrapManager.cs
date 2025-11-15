using UnityEngine;

public class screenWrapManager : MonoBehaviour
{
    // handle the spawning of the wrap colliders
    // used to be an attempt at screen wrap management, now it just handles cleanup of missiles
    [Header("prefabs for each wrap side")]
    public GameObject horizWrapObj;
    public GameObject vertWrapObj;
    [Header("offset from the game area to spawn")]
    public float cameraOffset = 1f;
    float cameraHeight;
    float cameraWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // get camera size to handle spawning the objects slightly outside the game frame
        Camera mainCamera = Camera.main;
        cameraHeight = mainCamera.orthographicSize; // ortho size for height
        cameraWidth = cameraHeight * mainCamera.aspect; // use aspect for width
        cameraHeight += cameraOffset; // add offset
        cameraWidth += cameraOffset; // ditto
        // top
        Instantiate(horizWrapObj, new Vector3(0, cameraHeight, 0), Quaternion.identity);
        // bottom
        Instantiate(horizWrapObj, new Vector3(0, -cameraHeight, 0), Quaternion.identity);
        // left
        Instantiate(vertWrapObj, new Vector3(-cameraWidth, 0,0), Quaternion.identity);
        // right
        Instantiate(vertWrapObj, new Vector3(cameraWidth, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
