using UnityEngine;

public class trackToObject : MonoBehaviour
{
    public string targetTag = "Player";
    private Transform target;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject targetObject = GameObject.FindGameObjectWithTag(targetTag);
        if (targetObject != null)
        {
            target = targetObject.transform;
        }
        else
        {
            Debug.LogWarning("something has gone horribly wrong HOOOOLY FUCK WHERE IS THE PLAYER");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            float currentY = transform.position.y;
            float currentZ = transform.position.z;
            transform.position = new Vector3(target.position.x, currentY, currentZ);
        }
    }
}
