using UnityEngine;

public class createThings : MonoBehaviour
{
    public GameObject prefab;
    public int lowerLimit = 1; // range to gen
    public int upperLimit = 5;
    public float cameraOffset = 1f;
    int count;
    public float xlimit = 5;
    public float ylimit = 2;
    public bool useScreenSizeForLimit = false;
    public bool enableRotation = false;
    float cameraHeight;
    float cameraWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        count = Random.Range(lowerLimit, upperLimit); // random range to spawn
        if(useScreenSizeForLimit == true)
        {
            Camera mainCamera = Camera.main;
            cameraHeight = mainCamera.orthographicSize;
            cameraWidth = cameraHeight * mainCamera.aspect;
            cameraHeight = cameraHeight - cameraOffset; // offset for sprite, adjustable for fairer spawns
            cameraWidth = cameraWidth - cameraOffset;
        }
        for(int i = 0; i < count; i++)
        {
            GameObject g;
            if (useScreenSizeForLimit == false)
            {
                g = Instantiate(prefab, new Vector2(Random.Range(-xlimit, xlimit), Random.Range(-ylimit, ylimit)), Quaternion.identity); // random location, no rotation, instantiated
            } else // between coordinates of current screen area, ideal for games where the camera doesnt move
            {
                g = Instantiate(prefab, new Vector2(Random.Range(-cameraWidth, cameraWidth), Random.Range(-cameraHeight, cameraHeight)), Quaternion.identity); // random location, no rotation, instantiated
            }
            if(enableRotation == true) { 
                Rigidbody2D grb = g.GetComponent<Rigidbody2D>();
                grb.rotation = Random.Range(0, 359);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
