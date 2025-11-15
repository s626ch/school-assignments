using UnityEngine;

public class spawnerHandler : MonoBehaviour
{
    // bottom of the screen offset
    public float yOffset = 0.5f;
    void Start()
    {
        PositionObject();
    }
    void PositionObject()
    {
        // viewport coordinates for the top edge:
        // x can be anything, e.g., 0.5 for the center of the screen horizontally
        // y is 0 for the bottom edge
        // z is the distance from the camera (essential for perspective cameras, but good practice for 2D too)
        // for 2D/Orthographic cameras, a z of 0 usually works fine, or the distance of the object from the camera
        Vector3 viewportPosition = new Vector3(0.5f, 1f, 0f);
        // convert viewport position to world position
        Vector3 worldPosition = Camera.main.ViewportToWorldPoint(viewportPosition);
        // adjust the Y position to account for the object's size and desired offset
        // assuming the object has a SpriteRenderer and its pivot is in the center
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            // adjust world position based on sprite bounds and offset
            worldPosition.y += spriteRenderer.bounds.size.y / 2 + yOffset;
        }
        else
        {
            // if no SpriteRenderer, just apply the offset
            worldPosition.y += yOffset;
        }
        // set the object's position
        transform.position = new Vector3(transform.position.x, worldPosition.y, transform.position.z);
    }
}