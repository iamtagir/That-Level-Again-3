using UnityEngine;
using System.Collections;

public class part1scr : MonoBehaviour {

    public GameObject black;
    public GameObject text;
    private SpriteRenderer sr;
    public bool isStart = false;
    public static part1scr instance;
    private float alp = 1;

    void OnEnable()
    {
        room1Scr.instance.setText(LocScr.getText(1));


        text.GetComponent<MeshRenderer>().sortingOrder = 50;
        text.GetComponent<TextMesh>().text = LocScr.getText(0);
        text.transform.position = LocScr.startPos;
    }


    void Awake()
    {
        instance = this;
        sr = black.GetComponent<SpriteRenderer>();
    }
	// Use this for initialization
	void Start () {
	
	}
	
    public void destroiText()
    {
        GameObject.Destroy(gameObject);
    }


	// Update is called once per frame
	void Update () {
        if(isStart)
        {
            alp = alp - 0.02f;
            if(alp>0)
                sr.color = new Color(0, 0, 0, alp);
            else
            {
                isStart = false;
                black.SetActive(false);
                roomScr.instance.didProgress();
            }
        }
	}





}
