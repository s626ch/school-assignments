using UnityEngine;

public class enemySpawner : MonoBehaviour
{
    [Header("spawner settings")]
    public GameObject enemyPrefab;
    public int lowerEnemLimit = 1;
    public int upperEnemLimit = 3;
    public float spawnInterval = 5f;
    [Header("spawn chance (0-100, percentage) per interval check")]
    public float spawnChance = 25f;
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
        int count = Random.Range(lowerEnemLimit, upperEnemLimit);
        float randomChance = Random.Range(0f, 100f);
        if (randomChance <= spawnChance)
        {
            for (int i = 0; i < count; i++)
            {
                Vector2 position;
                float x = Random.Range(-cameraWidth, cameraWidth);
                float y = Random.Range(-cameraHeight, cameraHeight);
                position = new Vector2(x, y);
                GameObject g = Instantiate(enemyPrefab, position, Quaternion.identity);
            }
        }
    }
}
