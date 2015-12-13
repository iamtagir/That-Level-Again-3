using UnityEngine;
using System.Collections;

public class MenuScr : MonoBehaviour {

    public string loadLevel = "1";
	// Use this for initialization
	void Start () {
        Application.LoadLevel(loadLevel);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
