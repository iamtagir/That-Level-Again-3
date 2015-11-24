using UnityEngine;
using System.Collections;

public class EndLevelScr : MonoBehaviour {

    public int id;
	// Use this for initialization
	void Start () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //gameObject.SetActive(false);
            //CameraScr.instance.moveTo(true);
            loadNext();
        }
    }


    public void loadNext()
    {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
