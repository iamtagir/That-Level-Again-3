using UnityEngine;
using System.Collections;

public class GravityChangerScr : MonoBehaviour {

    public int side = 0;

	// Use this for initialization
	void Start () {
	
        if(side == 0)
        {
            
        }

        if(side == 1)
        {
            transform.rotation = new Quaternion(0, 0, 1, 1);
        }

        if (side == 2)
        {
            transform.rotation = new Quaternion(0, 0, 1, 0);
        }

        if (side == 3)
        {
            transform.rotation = Quaternion.Euler(0, 0, -90);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        CoreWorld.instance.signalChanger();
        if(side == 0)
        {
            Physics2D.gravity = new Vector2(0, -9.81f);
            MyConst.isGravity = 0;
            PlayerScr.instance.turnTo(0);
        }

        gameObject.SetActive(false);

    }


    // Update is called once per frame
    void Update () {
	
	}
}
