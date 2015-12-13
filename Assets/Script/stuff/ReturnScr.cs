using UnityEngine;
using System.Collections;

public class ReturnScr : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            PlayerScr.instance.transform.position = new Vector3(-9.38f, 0, 0);
        }
    }
}
