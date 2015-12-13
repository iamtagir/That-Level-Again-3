using UnityEngine;
using System.Collections;

public class leftT : MonoBehaviour {

    public GameObject resume;
    Vector3 fin;
    Vector3 vec, vec2;
    public bool can = false;
    private bool ist = true;

    void OnEnable()
    {

    }

    void Start()
    {

        vec2 = roomCamera.instance.cam.ScreenToWorldPoint(resume.transform.position);
        vec2.z = 0;
        vec2.y += 0.6f;
        transform.position = vec2;
        fin = RoomUI.instance.b_right.transform.position;
        fin = roomCamera.instance.cam.ScreenToWorldPoint(fin);
    }


    void OnMouseDown()
    {
        if (ist)
        {
            GetComponent<SpriteRenderer>().enabled = true;
            ist = false;
            PauseSceneScr.instance.resumeGame();
            room1Scr.instance.setText(LocScr.getText(12));
        }
    }


    void OnMouseDrag()
    {
        vec = roomCamera.instance.cam.ScreenToWorldPoint(Input.mousePosition);
        vec.z = 0;
        vec.y += 0.5f;
        transform.position = vec;
        if (MyConst.equal(vec, fin, 0.6f))
        {
            gameObject.SetActive(false);
            RoomUI.instance.b_right.SetActive(true);
        }

    }

    void Update()
    {
        if (ist)
        {
            vec2 = roomCamera.instance.cam.ScreenToWorldPoint(resume.transform.position);
            vec2.z = 0;
            vec2.y += 0.6f;
            transform.position = vec2;
        }
    }
}
