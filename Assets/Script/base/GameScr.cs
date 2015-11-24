using UnityEngine;
using System.Collections;
using SmartLocalization;

public class GameScr : MonoBehaviour {

    public string keyText = "text1";
    public GameObject text;

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
    }
	
	// Update is called once per frame
	void Update () {


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
    public void clkPause()
    {
        Application.LoadLevel(0);
    }



}
