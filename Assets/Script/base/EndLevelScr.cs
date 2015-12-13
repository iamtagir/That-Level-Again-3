using UnityEngine;
using System.Collections;

public class EndLevelScr : MonoBehaviour {

    public static Vector2 lastPos;
    public string nextLevel;
	// Use this for initialization
	void Start () {
        //print(Application.loadedLevelName);
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            loadNext();
        }
    }


    public void loadNext()
    {
        lastPos = PlayerScr.instance.transform.position;
        Application.LoadLevel(nextLevel);
    }
}
