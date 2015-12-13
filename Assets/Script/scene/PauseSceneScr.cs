using UnityEngine;
using System.Collections;

public class PauseSceneScr : MonoBehaviour {

    public static PauseSceneScr instance;
    public GameObject pauseBlock;
    private RectTransform rt;
    private bool isStart = false, isFinish = false;
    private float speed = 8f;
    private float startPos;

    void Awake()
    {
        instance = this;
    }

	// Use this for initialization
	void Start () {
        isStart = true;
        rt = pauseBlock.GetComponent<RectTransform>();
        startPos = rt.localPosition.y;
        Time.timeScale = 0;
    }

    void OnEnable()
    {
        isStart = true;
    }

	

	// Update is called once per frame
	void Update () {
        if (isStart)
        {
            if(rt.localPosition.y > startPos - 280)
                rt.localPosition = new Vector3(0, rt.localPosition.y - speed, 0);
            else
            {
                rt.localPosition = new Vector3(0, startPos - 280, 0);
                isStart = false;
            }
        }
        if(isFinish)
        {
            if (rt.localPosition.y < startPos)
                rt.localPosition = new Vector3(0, rt.localPosition.y + speed, 0);
            else
            {
                rt.localPosition = new Vector3(0, startPos, 0);
                isFinish = false;
                gameObject.SetActive(false);
                Time.timeScale = 1;
                //Destroy(gameObject);
            }
        }
	}
    


    public void resumeGame()
    {
        isFinish = true;
    }
}
