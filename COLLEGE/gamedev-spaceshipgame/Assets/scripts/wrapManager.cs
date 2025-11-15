using UnityEngine;

public class wrapManager : MonoBehaviour
{
    // this script is purely for managing screen wrap, will be applied to rocks and the enemy ship
    [Header("camera offset for screen wrap")]
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
    }

    // Update is called once per frame
    void Update()
    {
        float currX = transform.position.x;
        float currY = transform.position.y;
        float currZ = transform.position.z;
        if (currY < -cameraHeight) // flip your y for bottom/top
        {
            transform.position = new Vector3(currX, -(currY + 0.5f), currZ);
        }
        if (currY > cameraHeight)
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
}
