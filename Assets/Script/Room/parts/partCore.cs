using UnityEngine;
using System.Collections;

public class partCore : MonoBehaviour {

    public static partCore instance;
    protected Vector3 vec;
    //protected GameObject go;

    // Use this for initialization
    void Start () {
	
	}

    void OnEnable()
    {
        instance = this;
    }
	
    public void Inst()
    {
        instance = this;
    }

	// Update is called once per frame
	void Update () {
	
	}

    public virtual void doOne()
    {
        print("D");
    }

    public virtual void refresh()
    {

    }
}
