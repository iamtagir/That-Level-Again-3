using UnityEngine;
using System.Collections;

public class touchThis : MonoBehaviour {

    private bool exit = false;

	// Use this for initialization
	void Start ()
    {

    }

    void OnMouseDown()
    {        
        exit = false;
        transform.localScale = new Vector3(1.2f, 1.2f, 1);
    }

    void OnMouseExit()
    {
        exit = true;
        transform.localScale = new Vector3(1, 1, 1);
    }


    void OnMouseUp()
    {
        if (!exit)
        {
            transform.localScale = new Vector3(1, 1, 1);
            roomScr.instance.playSound(0);
            part1scr.instance.isStart = true;
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
