using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyboardScene : MonoBehaviour {

    public static KeyboardScene instance;
    public GameObject board;
    public GameObject text;
    private TextMesh textMesh;
    public string nowText = "";
    private string textForTake;
    private float speed = 15, startPos;
    private bool isStart, isFinish;
    private RectTransform rt;
    public bool isShow;
    private int idinstr;
    private string oldtext;
    private int toches = 0;


    void Awake()
    {
        instance = this;
        textMesh = text.GetComponent<TextMesh>();
        textForTake = "";
        for (int i = 0; i < board.transform.childCount; i++)
        {
            textForTake = textForTake + board.transform.GetChild(i).GetChild(0).GetComponent<Text>().text;
        }
        rt = board.GetComponent<RectTransform>();
        isStart = false;
        isFinish = false;
        isShow = false;
        idinstr = 0;
        Application.DontDestroyOnLoad(this);
        gameObject.SetActive(false);

    }



    public void downButton(int id)
    {
        if (toches == 0)
            oldtext = textMesh.text;
        else
            return;
        textMesh.text = textMesh.text + textForTake[id];
        toches++;
    }

    public void upButton()
    {
        if (textMesh.text == nowText)
        {
            GameScr.instance.keyboardSignal();
            return;
        }

        if (nowText == "")
        {
            textMesh.text = "";
        }
        else if(nowText != "anyText")
        {
            if (idinstr >= nowText.Length)
            {
                return;
            }
            if (nowText[idinstr] != textMesh.text[idinstr])
            {
                textMesh.text = oldtext;
            }
            else
                idinstr++;
        }
        toches--;
    }

    // Use this for initialization
    void Start ()
    {
        startPos = rt.localPosition.y;

    }
	
	// Update is called once per frame
	void Update () {

        /*
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if (isShow)
                hide();
            else
                show();
        }*/
        
        if (isStart)
        {
            if (rt.localPosition.y <  startPos + 326)
                rt.localPosition = new Vector3(0, rt.localPosition.y + speed, 0);
            else
            {
                rt.localPosition = new Vector3(0, startPos + 326, 0);
                isStart = false;
                isShow = true;
            }
        }
        if (isFinish)
        {
            if (rt.localPosition.y > startPos)
                rt.localPosition = new Vector3(0, rt.localPosition.y - speed, 0);
            else
            {
                rt.localPosition = new Vector3(0, startPos, 0);
                isFinish = false;
                isShow = false;
                gameObject.SetActive(false);
                // Destroy(gameObject);
            }
        }
    }

    public void refresh()
    {
        textMesh.text = "";
        nowText = "";
        isStart = false;
        isFinish = false;
        idinstr = 0;
        toches = 0;
        text.SetActive(false);
    }

    public void show()
    {
        gameObject.SetActive(true);
        isStart = true;
        text.SetActive(true);
    }

    public void hide()
    {
        isFinish = true;
        text.SetActive(false);
    }

    public void hide2()
    {
        isFinish = true;
    }

    public void changeView()
    {
        if (isShow)
                hide();
            else
                show();
    }


}
