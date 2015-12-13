using UnityEngine;
using System.Collections;

public class part4 : partCore
{

    void OnEnable()
    {
        Inst();
        room1Scr.instance.setText(LocScr.getText(10));
        room1Scr.instance.setText(LocScr.getText(11), 2.2f);
    }
        // Use this for initialization
        void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
