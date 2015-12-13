using UnityEngine;
using System.Collections;

public class World4 : CoreWorld
{

    private TextMesh mainText;
    private string str;
    public GameObject key;
    // Use this for initialization

    void Awake()
    {
        instance = this;
    }

    void Start () {

        flag = true;
        mainText = GameObject.Find("MainText").GetComponent<TextMesh>();

        if (!MyConst.isStart && EndLevelScr.lastPos.x < 0)
        {
            PlayerScr.instance.Set(8, EndLevelScr.lastPos.y);
        }
        Physics2D.gravity = new Vector2(9.81f, 0);
        PlayerScr.instance.gameSide = 1;
        PlayerScr.instance.transform.rotation = new Quaternion(0, 0, 1, 1);
    }
	

	void Update () {

        //if (MyConst.isGravity == 1 && Input.acceleration.y <= -0.8f)
        //    turnGame();

    }

    public void turnGame()
    {
        Physics2D.gravity = new Vector2(0, -9.81f);
        PlayerScr.instance.transform.rotation = new Quaternion(0, 0, 0, 0);
        PlayerScr.instance.gameSide = 0;
        MyConst.isGravity = 0;
    }

    public override void signalKey()
    {
        base.signalKey();
    }

    void OnDestroy()
    {
        if (PlayerScr.instance.isKey())
            MyConst.isWorld4 = true;
        Physics2D.gravity = new Vector2(0, -9.81f);
    }


}
