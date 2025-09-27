using UnityEngine;

public class coinCollect : MonoBehaviour
{
    public string tagname = "Treasure"; // tagged object to collect
    void OnCollisionEnter2D(Collision2D collision)
    {
        //Debug.Log("Touched");
        // collided object reference
        GameObject other = collision.gameObject;
        //Debug.Log(other.name);
        //look for tag
        if (other.CompareTag(tagname))
        {
            //Debug.Log("COINER!!!");
            GameObject.Destroy(other); // bye
        }
    }
}
