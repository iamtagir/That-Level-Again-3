using UnityEngine;
using System.Collections;

public class World5 : CoreWorld
{
    private float dx = 0, dy = 0, da = 0, allD;
    public GameObject leftButton, upButton;
    private Vector3 pos2;
    private bool flag2 = false;
    void Awake()
    {
        instance = this;
    }

    void Start ()
    {
        pos2 = upButton.transform.position;
        allD = pos2.x - leftButton.transform.position.x;
    }

    void Update()
    {

        vec = Input.mousePosition;
        //vec.y += CS;
        //CS = Screen.width / 16;
        /*
        if (Input.GetMouseButtonDown(0))
        {
            flag = MyConst.equal(leftButton.transform.position, vec, CS);
            dx = leftButton.transform.position.x - vec.x;
            dy = leftButton.transform.position.y - vec.y;
        }*/

        if (flag)
        {
            vec.y += dy;
            vec.x += dx;
            if (MyConst.equal(vec, pos2, CS * 0.7f) && !flag2)
            {
                flag2 = true;
                upButton.SetActive(true);
                leftButton.SetActive(false);
            }
            else
            {
                da = (MyConst.dist(pos2, leftButton.transform.position) / allD);
                da = (da < 0) ? 0 : (da > 1) ? 1: da;
                da = 1 - da;
                da *= -90;
                leftButton.transform.rotation = Quaternion.Euler(new Vector3(0, 0, da));
                leftButton.transform.position = vec;
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            flag = false;
        }
    }

    public void clkLeft()
    {
        flag = true;
        vec = Input.mousePosition;
        dx = leftButton.transform.position.x - vec.x;
        dy = leftButton.transform.position.y - vec.y;
    }



}
