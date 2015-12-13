using UnityEngine;
using System.Collections;

public class DoorScr : MonoBehaviour {

    private GameObject door1, door2;
    private bool isOpen;
	// Use this for initialization
	void Start () {
        isOpen = false;
        door1 = transform.GetChild(0).gameObject;
        door2 = transform.GetChild(1).gameObject;

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player" && PlayerScr.instance.isKey())
        {
            open();
            PlayerScr.instance.removeKey();
        }

    }

    public void open()
    {
        CoreWorld.instance.signalDoor();
        isOpen = true;
        door1.SetActive(false);
        door2.SetActive(true);
        GetComponent<BoxCollider2D>().enabled = false;
    }

}
