using UnityEngine;
using System.Collections;

public class RoomUI : MonoBehaviour {


    public static RoomUI instance;
    public GameObject b_left, b_right, b_up, b_help, b_keyboard, b_pause;

    public GameObject pause;

    void Awake()
    {
        instance = this;
    }

    public void giveUp()
    {
        b_up.SetActive(true);
    }

    public void doInvoke(string func, float ff)
    {
        Invoke(func, ff);
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

        //KeyboardScene.instance.changeView();

        //GameObject.Instantiate(new KeyboardScene());
        //   Application.LoadLevelAdditive("keyboard");
    }

    public void clkHelp()
    {

    }


    public void clkPause()
    {
        pause.SetActive(true);
    }

}
