using UnityEngine;
using System.Collections;

public class CoreWorld : MonoBehaviour {

    public static CoreWorld instance;
    protected Vector3 vec;
    protected bool flag = false;
    protected float CS = Screen.width / 16f;

    // Use this for initialization
    void Start () {
	
	}
	
    virtual public void signalDoor()
    {

    }

    virtual public void signalKey()
    {

    }

    virtual public void signalChanger()
    {

    }

}
