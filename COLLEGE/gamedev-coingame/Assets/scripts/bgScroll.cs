using System.Collections.Generic;
using UnityEngine;

public class bgScroll : MonoBehaviour
{
    public GameObject backgroundPrefab;
    public Transform cameraTransform;
    public float buffer = 2f;
    public float scrollSpeed = 0f;
    private float tileWidth;
    private List<GameObject> tiles = new List<GameObject>();
    private float lastCameraX;
    void Start()
    {
        tileWidth = backgroundPrefab.GetComponent<BoxCollider2D>().size.x * backgroundPrefab.transform.localScale.x;
        lastCameraX = cameraTransform.position.x;
        float screenWidth = Camera.main.orthographicSize * 2f * Camera.main.aspect;
        int initialTileCount = Mathf.CeilToInt(screenWidth / tileWidth) + 2;
        for (int i = -1; i < initialTileCount - 1; i++)
        {
            Vector3 pos = new Vector3(i * tileWidth, transform.position.y, transform.position.z);
            GameObject tile = Instantiate(backgroundPrefab, pos, Quaternion.identity, transform);
            tiles.Add(tile);
        }
    }
    void Update()
    {
        float cameraX = cameraTransform.position.x;
        float leftEdge = cameraX - Camera.main.orthographicSize * Camera.main.aspect - buffer;
        float rightEdge = cameraX + Camera.main.orthographicSize * Camera.main.aspect + buffer;
        if (scrollSpeed != 0f)
        {
            foreach (GameObject tile in tiles)
            {
                tile.transform.position += Vector3.left * scrollSpeed * Time.deltaTime;
            }
        }
        if (tiles.Count > 0)
        {
            GameObject lastTile = tiles[tiles.Count - 1];
            //while (lastTile.transform.position.x + tileWidth < rightEdge)
            while (lastTile.transform.position.x < rightEdge)
            {
                Vector3 newPos = lastTile.transform.position + Vector3.right * tileWidth;
                GameObject newTile = Instantiate(backgroundPrefab, newPos, Quaternion.identity, transform);
                tiles.Add(newTile);
                lastTile = newTile;
            }
        }
        if (tiles.Count > 0)
        {
            GameObject firstTile = tiles[0];
            while (firstTile.transform.position.x > leftEdge)
            {
                Vector3 newPos = firstTile.transform.position - Vector3.right * tileWidth;
                GameObject newTile = Instantiate(backgroundPrefab, newPos, Quaternion.identity, transform);
                tiles.Insert(0, newTile);
                firstTile = newTile;
            }
        }
        for (int i = tiles.Count - 1; i >= 0; i--)
        {
            float tileX = tiles[i].transform.position.x;
            if (tileX + tileWidth < leftEdge || tileX > rightEdge + tileWidth)
            {
                Destroy(tiles[i]);
                tiles.RemoveAt(i);
            }
        }
        lastCameraX = cameraX;
    }
}