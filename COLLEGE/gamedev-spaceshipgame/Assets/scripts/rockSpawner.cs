using UnityEngine;
using UnityEngine.UIElements;

public class rockSpawner : MonoBehaviour
{
    [Header("spawner settings")]
    public GameObject objToSpawn;
    public int lowerObjLimit = 1;
    public int upperObjLimit = 10;
    public float spawnInterval = 2f;
    [Header("spawn chance (0-100, percentage) per interval check")]
    public float spawnChance = 25f;
    [Header("asteroidlike movement settings")]
    public float minDriftForce = 0.5f;
    public float maxDriftForce = 3f;
    public float minTorque = 0.5f;
    public float maxTorque = 2f;
    private float timer = 0f;
    float cameraHeight;
    float cameraWidth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera mainCamera = Camera.main;
        cameraHeight = mainCamera.orthographicSize;
        cameraWidth = cameraHeight * mainCamera.aspect;
        spawnObjects();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= spawnInterval)
        {
            spawnObjects();
            timer = 0f;
        }
    }
    void spawnObjects()
    {
        int count = Random.Range(lowerObjLimit, upperObjLimit);
        float randomChance = Random.Range(0f, 100f);
        if(randomChance <= spawnChance) { 
            for (int i = 0; i < count; i++)
            {
                Vector2 position;
                float x = Random.Range(-cameraWidth, cameraWidth);
                float y = Random.Range(-cameraHeight, cameraHeight);
                position = new Vector2(x, y);
                GameObject g = Instantiate(objToSpawn, position, Quaternion.identity);
                // call function for asteroid behavior
                configAsteroidForce(g);
            }
        }
    }

    void configAsteroidForce(GameObject asteroid)
    {
        Rigidbody2D rb = asteroid.GetComponent<Rigidbody2D>();
        if (rb == null) return;
        // random initial rotation
        rb.rotation = Random.Range(0f, 360f);
        // apply random torque/rotational force
        float torque = Random.Range(minTorque, maxTorque);
        torque *= (Random.Range(0, 2) == 0) ? 1f : -1f; // random rotational direction
        rb.AddTorque(torque, ForceMode2D.Impulse);
        // random object drift force
        float driftForce = Random.Range(minDriftForce, maxDriftForce);
        Vector2 driftDirection = Random.insideUnitCircle.normalized; // a completely random direction from inside a 1.0 radii circle
        rb.AddForce(driftDirection * driftForce, ForceMode2D.Impulse);
        // further random angular velocity for super awesome extra spin variation
        rb.angularVelocity = Random.Range(-30f, 30f);
    }
}