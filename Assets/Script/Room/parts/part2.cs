using UnityEngine;
using System.Collections;

public class part2 : partCore {

    public GameObject img1, img2;
    private float xx = 0, ssx = 0, dx = 0;
    private float scr_w;
    private float dpix;
    private float speed = 25f;
    private int igo = 0;
    private bool isStart = true, isRight = true;
    private bool done = false;
    private bool isRefresh = false;
    // Use this for initialization

    void OnEnable()
    {
        Inst();
        room1Scr.instance.setText(LocScr.getText(2));
    }

    void Start () {
        scr_w = MyConst.SCR_W;
        isStart = true;
    }

    
    // Update is called once per frame
    void Update () {



        vec = Input.mousePosition;
        if (Input.GetMouseButtonDown(0) && !done)
        {
            xx = vec.x;
        }


        if (Input.GetMouseButton(0) && !done)
        {
            if(Mathf.Abs(xx/scr_w - vec.x / scr_w) > 0.1f || ssx != 0)//влево
            {
                if(isStart)
                {
                    isStart = false;
                    if(- xx / scr_w + vec.x / scr_w > 0.1f)
                    {
                        img1.transform.position = new Vector3(-16, 0, 0);
                        img2.transform.position = new Vector3(16, 0, 0);
                        isRight = false;
                    }
                }

                if (ssx == 0)
                    ssx =  vec.x;
                dx = vec.x - ssx;
                dx = dx * MyConst.pX;
                transform.position = new Vector3(dx, 0, 0);
            }
        }

        if(Input.GetMouseButtonUp(0) && !done)
        {
            ssx = 0;
            if (transform.position.x < -7)
            {
                igo = 1;
            }
            else if(transform.position.x > 7)
            {
                igo = 2;
            }
            else
            {
                igo = 3;
            }
        }

        if(igo!=0)
        {
            if (igo == 1)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(-16, 0, 0), speed * Time.deltaTime);
                if (transform.position.x == -16)
                {
                    igo = 0;
                    finish(!isRight);
                }
                done = true;
            }
            else if (igo == 2)
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(16, 0, 0), speed * Time.deltaTime);
                if (transform.position.x == 16)
                {
                    igo = 0;
                    finish(isRight);
                }
                done = true;
            }
            else
            {
                transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), speed * Time.deltaTime);
                if (transform.position.x == 0)
                {
                    igo = 0;
                    if (isStart)
                    {
                        PlayerScr.instance.gameObject.SetActive(true);
                        PlayerScr.instance.rb.gravityScale = 0;
                        PlayerScr.instance.transform.position = new Vector3(0, -1, 0);
                        room1Scr.instance.setText(LocScr.getText(5));
                    }

                }
            }
        }
	}


    //тру - жив
    private void finish(bool side)
    {
        if(side)
        {
            room1Scr.instance.setText(LocScr.getText(4));
            Invoke("cont", 0.5f);
            room1Scr.instance.plats.SetActive(true);

        }
        else
        {
            room1Scr.instance.setText(LocScr.getText(3));
            Invoke("fin", 0.5f);
            Invoke("fin2", 1.1f);
        }
    }

    public void cont()
    {
        PlayerScr.instance.rb.gravityScale = 1;
        roomScr.instance.didProgress();
        gameObject.SetActive(false);
    }

    public void fin()
    {
        PlayerScr.instance.rb.gravityScale = 1;
    }

    public void fin2()
    {
        PlayerScr.instance.gameObject.SetActive(false);
        PlayerScr.instance.die();
        Invoke("refresh", 0.5f);
    }


    override public void refresh()
    {
        CorpseScr.instance.gameObject.SetActive(false);
        igo = 3;
        done = false;
        isStart = true;
    }
}
