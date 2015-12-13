using UnityEngine;
using System.Collections;

public class CorpseScr : MonoBehaviour {

    public static CorpseScr instance;
    public static bool isShow;

    void OnEnable()
    {
        isShow = true;
    }

    void OnDisable()
    {
        isShow = false;
    }

    void Awake()
    {
        isShow = false;
        instance = this;
    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
