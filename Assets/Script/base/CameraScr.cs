using UnityEngine;
using System.Collections;

public class CameraScr : MonoBehaviour {

    public static CameraScr instance;

    public bool fewScreens = false;
    public float speed = 10;
    public float needWidth = 9f;
    public Vector2 offset;
    public Vector2 minMaxY;
    public float glitch = 16;

    private Transform tr;
    private Transform trPlayer;
    private float mySpeed = 0, startPos = 0;
    private bool startToMove = false;
    private Vector3 vec = new Vector3(0,0,-10);
    private float tY;
    private int cameraPos;
	// Use this for initialization
	void Awake () {
        tr = GetComponent<Transform>();
        instance = this;
        Camera.main.orthographicSize = needWidth / Screen.width * Screen.height;
        cameraPos = 0;
    }

    void Start()
    {
        trPlayer = PlayerScr.instance.GetComponent<Transform>();
    }
	
	// Update is called once per frame
	void LateUpdate () {


        if(fewScreens)
        {
            if((int)(trPlayer.position.x+8)/16 != cameraPos)
            {
                cameraPos = (int)(trPlayer.position.x + 8) / 16;
                transform.position = new Vector3(cameraPos * 16, 0, -10);
            }
        }


        //moveCamera();

        //Camera.main.orthographicSize = 7;
        //TrackPlayer();
    }

    public void TrackPlayer()
    {
        tY = Mathf.Clamp(trPlayer.position.y + offset.y, minMaxY.x, minMaxY.y);
        vec.Set(trPlayer.position.x + offset.x, tY, -10);
        tr.position = vec;
    }




    private void moveCamera()
    {
        if (mySpeed != 0)
        {
            vec.Set(vec.x + speed * Time.deltaTime, 0, -10);

            if (mySpeed > 0)
            {
                if (vec.x - startPos > glitch)
                {
                    vec.x = startPos + glitch;
                    mySpeed = 0;
                }
            }
            else
            {
                if (startPos - vec.x > glitch)
                {
                    vec.x = startPos - glitch;
                    mySpeed = 0;
                }
            }
            tr.position = vec;
        }
    }

    //direction == truy - right, else left;
    public void moveTo(bool direction)
    {
        if (direction)
            mySpeed = speed;
        else
            mySpeed = -speed;
        startPos = tr.position.x;
    }
}
