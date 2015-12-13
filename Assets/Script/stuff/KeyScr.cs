using UnityEngine;
using System.Collections;

public class KeyScr : MonoBehaviour
{

    public bool canTake = true;
    public bool isMass = true;
    // Use this for initialization
    void Start()
    {
        if (!isMass)
            GetComponent<Rigidbody2D>().gravityScale = 0;
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Player" && canTake)
        {
            PlayerScr.instance.getKey();
            Destroy(gameObject);
        }

    }

}