using UnityEngine;
using System.Collections;

public class shaker : MonoBehaviour {

    public int i = 0, raz = 0;

    public GameObject rightT;
    private Vector3 vec = new Vector3(0, 0, -10);
    private float speed = 0.025f;
	// Use this for initialization
	void Start () {
        i = 0;
        raz = 0;
	}

    bool shake = false;

    void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.tag == "Player" && i < 10)
        {
            if (i > 1)
            {
                shake = true;
                if(i%2 == 0)
                    roomScr.instance.playSound(1);
                Vector3 v = rightT.transform.position;
                v.y -= 0.15f;
                rightT.transform.position = v;
                
            }
            i++;
            if(i == 3)
            {
                room1Scr.instance.setText(LocScr.getText(8));
            }
            if (i == 10)
            {
                rightT.GetComponent<rightT>().fallNow();
                room1Scr.instance.setText(LocScr.getText(9));
            }
        }
    }

    // Update is called once per frame
    void Update () {
        if(shake)
        {
            vec.y = vec.y + speed;
            if (vec.y > 0.07f || vec.y < -0.05f)
            {
                raz++;
                speed = -speed;
                vec.y = vec.y + speed;
            }
            if(raz >= 3)
            {
                if(vec.y >= -0.03f && vec.y <= 0.03f)
                {
                    raz = 0;
                    shake = false;
                    vec.y = 0;
                }
            }
            roomCamera.instance.transform.position = vec;
        }
	
	}


}
