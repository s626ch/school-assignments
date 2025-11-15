using UnityEngine;

public class createThings : MonoBehaviour
{
    public GameObject prefab;
    public int lowerLimit = 1; // range to gen
    public int upperLimit = 5;
    public float cameraOffset = 1f;
    public float xlimit = 5;
    public float ylimit = 2;
    public bool roundToInt = false;
    public float spawnInterval = 2f; // time between spawns in seconds
    public bool loopInfinitely = true;
    public int maxSpawnCycles = 0;
    private int currentCycle = 0;
    private float timer = 0f;
    public float interObjectDelay = 0.1f;
    void Start()
    {
        spawnObjects();
        if (!loopInfinitely)
        {
            this.enabled = false;
        }
    }
    void Update()
    {
        if (loopInfinitely && (maxSpawnCycles == 0 || currentCycle < maxSpawnCycles))
        {
            timer += Time.deltaTime;

            if (timer >= spawnInterval)
            {
                spawnObjects();
                timer = 0f;
                currentCycle++;
            }
        }
        else if (currentCycle >= maxSpawnCycles && maxSpawnCycles > 0)
        {
            this.enabled = false;
        }
    }
    void spawnObjects()
    {
        int count = Random.Range(lowerLimit, upperLimit);
        StartCoroutine(SpawnObjectsWithDelay(count));
    }
    System.Collections.IEnumerator SpawnObjectsWithDelay(int count)
    {
        for (int i = 0; i < count; i++)
        {
            Vector2 position;
            if (roundToInt == true)
            {
                float x = Random.Range(-xlimit, xlimit);
                float y = Random.Range(-ylimit, ylimit);
                position = new Vector2(Mathf.RoundToInt(x), Mathf.RoundToInt(y));
            }
            else
            {
                float x = Random.Range(-xlimit, xlimit);
                float y = Random.Range(-ylimit, ylimit);
                position = new Vector2(x, y);
            }

            GameObject g = Instantiate(prefab, position, Quaternion.identity);

            // Configurable delay between each object spawn
            yield return new WaitForSeconds(interObjectDelay);
        }
    }
}