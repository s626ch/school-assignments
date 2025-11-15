using UnityEngine;

public class impactManager : MonoBehaviour
{
    public string missileTag = "missile";
    public string rockTag = "asteroid";
    public string enemyTag = "enemy";
    public GameObject explodePrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        float currentx = transform.position.x;
        float currenty = transform.position.y;
        float currentz = transform.position.z;
        GameObject other = collision.gameObject;
        if (other.CompareTag(missileTag) || other.CompareTag(rockTag) || other.CompareTag(enemyTag))
        {
            Instantiate(explodePrefab, new Vector3(currentx,currenty,currentz),Quaternion.identity);
            // both the impacted object and missile/rock/whatever needs to be destroyed
            Destroy(this.gameObject);
            Destroy(other);
        }
    }
}
