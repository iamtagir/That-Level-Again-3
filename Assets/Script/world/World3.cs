using UnityEngine;
using System.Collections;

public class World3 : MonoBehaviour {

    private TextMesh mainText;
    private string str;
    private bool flag;
	// Use this for initialization
	void Start () {

        flag = true;
        mainText = GameObject.Find("MainText").GetComponent<TextMesh>();
	}
	
	// Update is called once per frame
	void Update () {
         str = Input.acceleration.ToString();
         mainText.text = str;
        //if ( (flag && Input.acceleration.x >= 0.8f) || (!flag && Input.acceleration.y <= -0.8f) )
        if (flag && Input.acceleration.x >= 0.8f)
            turnGame();

        if (Input.GetKeyDown(KeyCode.Space))
            turnGame();

    }

    public void turnGame()
    {
        if (flag)
        {
            Physics2D.gravity = new Vector2(9.81f, 0);
            PlayerScr.instance.transform.rotation = new Quaternion(0, 0, 1, 1);
            PlayerScr.instance.gameSide = 1;
            MyConst.isGravity = 1;
        }
    }

    void OnDestroy()
    {
        //Physics2D.gravity = new Vector2(0, -9.81f);
    }


}
