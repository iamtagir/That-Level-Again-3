using UnityEngine;
using System.Collections;

public class room1Scr : MonoBehaviour {

    public GameObject text;
    public static room1Scr instance;
    private TextMesh tm;
    public GameObject plats;

    void OnEnable()
    {
        if(instance == null)
            instance = this;
    }

    void Awake()
    { 


        if (instance == null)
            instance = this;
        tm = text.GetComponent<TextMesh>();
    }

	// Use this for initialization
	void Start () {
        text.GetComponent<MeshRenderer>().sortingOrder = 8;
        //tm.text = LocScr.getText(1);
    }
	
	// Update is called once per frame
	void Update () {
	
	}


    public void setText(string str_for_text)
    {
        tm.text = str_for_text;
    }




    private string tft;

    public void setText(string str_for_text, float tt)
    {
        tft = str_for_text;
        Invoke("setText2", tt);
    }

    public void setText2()
    {
        tm.text = tft;
    }


}
