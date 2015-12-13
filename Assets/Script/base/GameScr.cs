using UnityEngine;
using System.Collections;

public class GameScr : MonoBehaviour {

    public string keyText = "text1";
    public GameObject text;
    public static GameScr instance;
    public bool canGoBack = true;
    private Transform p_t;

    void Awake()
    {
        //Если что тут может быть потеря памяти?
        instance = this;
    }
    // Use this for initialization
    void Start()
    {
        //print(Application.systemLanguage);
        /* if (LanguageManager.Instance.GetSupportedSystemLanguage() != null)
         {
             LanguageManager.Instance.ChangeLanguage(LanguageManager.Instance.GetSupportedSystemLanguage());
         }
         text.GetComponent<TextMesh>().text = LanguageManager.Instance.GetTextValue(keyText);
         */

        if (KeyboardScene.instance == null)
        {
            Instantiate(Resources.Load("Keyboard") as GameObject);
        }
        p_t = PlayerScr.instance.transform;
        MyConst.isStart = false; 
    }
	
	// Update is called once per frame
	void Update () {
        if(!canGoBack)
        {
            if(p_t.position.x < -7.5f)
            {
                p_t.position = new Vector3(-7.5f, p_t.position.y, p_t.position.z);
            }
        }
        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

    }


    public void clkLeft()
    {
        PlayerScr.instance.goLeft();
    }
    public void clkRight()
    {
        PlayerScr.instance.goRight();
    }
    public void clkUp()
    {
        PlayerScr.instance.goJump();
    }
    public void clkStop()
    {
        PlayerScr.instance.goStop();
    }

    public void clkKeyboard()
    {
        
        KeyboardScene.instance.changeView();

        //GameObject.Instantiate(new KeyboardScene());
        //   Application.LoadLevelAdditive("keyboard");
    }

    public void clkHelp()
    {

    }


    public void clkPause()
    {
        Application.LoadLevelAdditive("pause");
    }


    public void keyboardSignal()
    {
        print("keyboardSignal");
    }

}
