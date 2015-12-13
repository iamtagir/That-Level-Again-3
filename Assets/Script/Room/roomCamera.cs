using UnityEngine;
using System.Collections;

public class roomCamera : MonoBehaviour {

    public static roomCamera instance;

    public float needWidth = 8f;
    private float speed = 30f;

    private bool isMove = false;
    private Vector2 cameraPos = new Vector2(0, 0);
    private int xmove = 0, ymove = 0;
    private Vector3 vec = new Vector3(0, 0, -10);
    private Transform tr;
    public Camera cam;

    void Awake()
    {        
        tr = GetComponent<Transform>();
        instance = this;
        Camera.main.orthographicSize = needWidth / Screen.width * Screen.height;
    }


    public void moveToId(int x, int y)
    {
        vec = tr.position;
        xmove = x;
        ymove = y;
        isMove = true;
        vec.x = x * 16;
        vec.y = y;

    }

    // Use this for initialization
    void Start ()
    {
        cam = GetComponent<Camera>();
    }


	
	// Update is called once per frame
	void LateUpdate () {
	    if(isMove)
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, vec, step);
            if (transform.position == vec)
                isMove = false;
        }
	}
}
