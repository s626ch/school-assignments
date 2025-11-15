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
    public bool roundToInt = false;
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
        for (int i = 0; i < count; i++)
        {
            Vector2 position;
            // round to whole ints for spawn position, this is used for the holes
            if (roundToInt == true)
            {
                // are we using the screen size? or not, if we are, use the camera screen size, otherwise random defined limits
                float x = useScreenSizeForLimit ? Random.Range(-cameraWidth, cameraWidth) : Random.Range(-xlimit, xlimit);
                float y = useScreenSizeForLimit ? Random.Range(-cameraHeight, cameraHeight) : Random.Range(-ylimit, ylimit);
                position = new Vector2(Mathf.RoundToInt(x), Mathf.RoundToInt(y));
            }
            else // without rounding to whole ints
            {
                // are we using the screen size? or not, if we are, use the camera screen size, otherwise random defined limits
                float x = useScreenSizeForLimit ? Random.Range(-cameraWidth, cameraWidth) : Random.Range(-xlimit, xlimit);
                float y = useScreenSizeForLimit ? Random.Range(-cameraHeight, cameraHeight) : Random.Range(-ylimit, ylimit);
                position = new Vector2(x, y);
            }
            // instantiate the prefab
            GameObject g = Instantiate(prefab, position, Quaternion.identity);
            // do we want stuff to rotate?
            if (enableRotation == true)
            {
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
