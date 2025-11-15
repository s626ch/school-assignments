using UnityEngine;

public class timerScript : MonoBehaviour
{
    public float countTime = 5f;
    public GameObject nextPrefab;
    GameObject parentObject;
    private void Start()
    {
        parentObject = GameObject.FindWithTag("Player");
    }
    // Update is called once per frame
    void Update()
    {
        if(countTime > 0)
        {
            countTime -= Time.deltaTime; // decrement normalized
        }
        else
        {
            if (nextPrefab != null)
            {
                GameObject nextObj = Instantiate(nextPrefab, parentObject.transform);
            }
            Destroy(this.gameObject);
        }
    }
}
