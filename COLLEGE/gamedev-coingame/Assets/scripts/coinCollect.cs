using UnityEngine;

public class coinCollect : MonoBehaviour
{
    public string playerTag = "Player";
    public string groundTag = "Ground";
    public GameObject explodePrefab;
    public GameObject collectPrefab;
    void OnCollisionEnter2D(Collision2D collision)
    {
        float currentx = transform.position.x;
        float currenty = transform.position.y;
        float currentz = transform.position.z;
        //Debug.Log("Touched");
        // collided object reference
        GameObject other = collision.gameObject;
        //Debug.Log(other.name);
        //look for tag
        if (other.CompareTag(playerTag))
        {
            Instantiate(collectPrefab, new Vector3(currentx,currenty + 0.5f,currentz), Quaternion.identity);
            Destroy(this.gameObject);
        }
        if (other.CompareTag(groundTag))
        {
            Instantiate(explodePrefab, new Vector3(currentx, currenty, currentz), Quaternion.identity);
            Destroy(this.gameObject);
        }
    }
}
