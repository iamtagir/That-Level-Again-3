using UnityEngine;
using System.Collections;

public class DragGO : MonoBehaviour {

    public Vector2 minMaxX;
    public Vector2 minMaxY;
    private Vector2 clkPos;
    private float dist, startY;
    private Transform tr;

	// Use this for initialization
	void Start () {
        tr = transform;
    }


    void OnMouseDown()
    {
        clkPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        startY = tr.position.y;
    }

    void OnMouseDrag()
    {

        dist = clkPos.y - Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
        tr.position = new Vector3(tr.position.x, startY - dist, 0);
        if (tr.position.y > minMaxY.y)
        {
            tr.position = new Vector3(tr.position.x, minMaxY.y, 0);
        }
        else if (tr.position.y < minMaxY.x)
        {
            tr.position = new Vector3(tr.position.x, minMaxY.x, 0);
        }
            
    }

    void OnMouseUp()
    {
        //print("OnMouseUp");
    }

    // Update is called once per frame
    void Update () {
	
	}
}
