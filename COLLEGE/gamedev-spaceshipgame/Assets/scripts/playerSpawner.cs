using UnityEngine;

public class playerSpawner : MonoBehaviour
{
    public GameObject playerPrefab;
    float cameraHeight;
    float cameraWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera mainCamera = Camera.main;
        cameraHeight = mainCamera.orthographicSize;
        cameraWidth = cameraHeight * mainCamera.aspect;
        Vector2 position;
        float x = Random.Range(-cameraWidth, cameraWidth);
        float y = Random.Range(-cameraHeight, cameraHeight);
        position = new Vector2(x, y);
        GameObject g = Instantiate(playerPrefab, position, Quaternion.identity);
        Rigidbody2D grb = g.GetComponent<Rigidbody2D>();
        grb.rotation = Random.Range(0, 359);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
