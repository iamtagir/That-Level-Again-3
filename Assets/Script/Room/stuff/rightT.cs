using UnityEngine;
using System.Collections;

public class rightT : MonoBehaviour {

    Vector3 fin;
    public bool ist = true;
    public bool fall = false;
    private bool can = false;
	// Use this for initialization
	void Start ()
    {
       fin = RoomUI.instance.b_left.transform.position;
       fin = roomCamera.instance.cam.ScreenToWorldPoint(fin);
    }

    void OnMouseDown()
    {
        if (!can) return;
        if (ist)
        {
            GetComponent<BoxCollider2D>().isTrigger = true;
            GetComponent<SpriteRenderer>().sortingOrder = 15;
            ist = false;
        }
    }


    void OnMouseDrag()
    {
        if (!can) return;
        Vector3 vec = roomCamera.instance.cam.ScreenToWorldPoint(Input.mousePosition);
        vec.z = 0;
        vec.y += 0.5f;
        transform.position = vec;
        if (MyConst.equal(vec, fin, 0.6f))
        {
            gameObject.SetActive(false);
            RoomUI.instance.b_left.SetActive(true);
            roomScr.instance.didProgress();
        }

    }

    void OnMouseUp()
    {

    }

    public void fallNow()
    {
        fall = true;
        v = transform.position;
    }
    Vector3 v;

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (fall)
        {
            if (v.y > 2.2f)
            {
                v.y -= 0.05f;
                transform.position = v;
            }
            else
            {
                fall = false;
                v.y = 2.25f;
                transform.position = v;
                can = true;
            }
        }

    }
}
