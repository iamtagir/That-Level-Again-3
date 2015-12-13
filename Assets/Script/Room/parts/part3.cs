using UnityEngine;
using System.Collections;

public class part3 : partCore {

    
    void OnEnable()
    {
        Inst();
        room1Scr.instance.setText(LocScr.getText(6));
        room1Scr.instance.setText(LocScr.getText(7), 2.2f);
        RoomUI.instance.Invoke("giveUp", 2f);
    }

	// Use this for initialization
	void Start ()
    {

    }


    void Awake()
    {
    }


    // Update is called once per frame
    void Update () {
	
	}
}
