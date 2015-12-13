using UnityEngine;
using System.Collections;

public class gameUIscr : MonoBehaviour {


    public void clkLeft()
    {
        GameScr.instance.clkLeft();
    }
    public void clkRight()
    {
        GameScr.instance.clkRight();
    }
    public void clkUp()
    {
        GameScr.instance.clkUp();
    }
    public void clkStop()
    {
        GameScr.instance.clkStop();
    }

    public void clkKeyboard()
    {

        GameScr.instance.clkKeyboard();

        //GameObject.Instantiate(new KeyboardScene());
        //   Application.LoadLevelAdditive("keyboard");
    }

    public void clkHelp()
    {
        GameScr.instance.clkHelp();
    }


    public void clkPause()
    {
        GameScr.instance.clkPause();
    }

}
