using UnityEngine;
using System.Collections;

public class roomScr : MonoBehaviour {

    public static int progress = 0;
    public static roomScr instance;
    public static int roomIdx = 0, roomIdy = 0;
    public GameObject [] parts;

    private Transform pl_tr, cam_tr;

    void Awake()
    {
        LocScr.setLaguage(Application.systemLanguage.ToString());
        instance = this;
        roomIdx = 0;
        MyConst.init();
    }
    // Use this for initialization
    void Start () {
        pl_tr = PlayerScr.instance.transform;
        cam_tr = roomCamera.instance.transform;
    }

	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();
        
        if (MyConst.minRoud((pl_tr.position.x + 8) / 16f) != roomIdx)
        {
            roomIdx = MyConst.minRoud((pl_tr.position.x + 8) / 16f);
            roomCamera.instance.moveToId(roomIdx, 0);
        }
        

    }
        
    public void playSound(int soundId)
    {
        switch(soundId)
        {
            case 0://щелчек
                print("щелк");
                break;
            case 1://упало что то тяжёлое
                print("boom");
                break;
        }
    }

    public void didProgress()
    {
        parts[progress].SetActive(false);
        progress++;
        parts[progress].SetActive(true);
    }



    public void loadlPart(int partId)
    {

        if (partId != 0)
            parts[0].SetActive(false);
        switch(partId)
        {
            case 1:
                parts[partId].SetActive(true);
                break;
            case 2:
                parts[partId].SetActive(true);
                break;
            case 3:
                parts[partId].SetActive(true);
                break;

        }
    }








}
