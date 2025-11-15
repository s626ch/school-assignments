using UnityEngine;

public class gameOverHandler : MonoBehaviour
{
    public GameObject gameOverScreen;
    public string playerTag = "Player";
    public string spawnerTag = "spawner";
    GameObject playerObject;
    GameObject[] spawnerObjs;
    bool isGameOver = false;
    bool playerWasFound = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        findPlayer();
        spawnerObjs = GameObject.FindGameObjectsWithTag(spawnerTag);
    }
    void findPlayer()
    {
        playerObject = GameObject.FindGameObjectWithTag(playerTag);
        if (playerObject != null)
        {
            playerWasFound = true;
        }
    }
    void FixedUpdate()
    {
        if (!playerWasFound)
        {
            findPlayer();
            return;
        }
        if(playerObject == null && !isGameOver)
        {
            Instantiate(gameOverScreen, new Vector2(0,0), Quaternion.identity);
            for(int i = 0; i < spawnerObjs.Length; i++)
            {
                Destroy(spawnerObjs[i]);
            }
            isGameOver = true;
        }
    }
}
