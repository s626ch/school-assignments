using UnityEngine;

public class backgroundManager : MonoBehaviour
{
    float cameraHeight;
    float cameraWidth;
    SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Camera mainCamera = Camera.main;
        cameraHeight = mainCamera.orthographicSize;
        cameraWidth = cameraHeight * mainCamera.aspect;
        sr.size = new Vector2(cameraWidth, cameraHeight);
    }
}
