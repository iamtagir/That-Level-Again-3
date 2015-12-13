using UnityEngine;

public static class MyConst{

    public static float SCR_W, SCR_H;
    public static float GAME_W = 16f, GAME_H;
    public static float pX, pY;




    public static bool isStart = true;
    public static bool isWorld4 = false;
    public static bool isDoor1 = false;
    public static bool changer1 = false;
    public static int isGravity = 1; // 0 - обычная / 1 - вправо / 2 - вверх / 3 - влево


    public static void init()
    {
        SCR_W = Screen.width;
        SCR_H = Screen.height;
        GAME_H = GAME_W * (SCR_H * 1.0f) / (SCR_W * 1.0f);
        pX = GAME_W / SCR_W;
        pY = GAME_H / SCR_H;

    }

    public static void refresh()
    {
        isStart = true;
        isWorld4 = false;
        isDoor1 = false;
        isGravity = 1;
        changer1 = false;

    }


    public static bool equal(float v1, float v2, float d = 0.001f)
    {
        return Mathf.Abs(v1 - v2) < d;
    }

    public static bool equal(Vector3 v1, Vector3 v2, float d = 2f)
    {
        return dist(v1, v2) < d;
    }

    public static float dist(Vector3 v1, Vector3 v2)
    {
        return Mathf.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y));
    }

    public static int minRoud(float val)
    {
        int cc;
        if (val > 0)
            cc = (int)val;
        else
            cc = (int)(val - 1);
        return cc;
    }


    /*

    public static float dist(Vector3 v1, Vector3 v2)
    {
        return Mathf.Sqrt((v1.x - v2.x) * (v1.x - v2.x) + (v1.y - v2.y) * (v1.y - v2.y));
    }


    public static float round(float x, float t)
    {
        int xx = (int)(x * t * 10);
        return ((float)xx) / (t * 10);
    }

    public static bool equal(float x1, float x2)
    {
        if ((Mathf.Abs(x1 - x2) < 0.01f))
            return true;
        else
            return false;
    }

    public static bool equal(float x1, float x2, float delta)
    {
        if ((Mathf.Abs(x1 - x2) < delta))
            return true;
        else
            return false;
    }


    public static bool equal(Vector3 pos1, Vector2 pos2)
    {
        float x1 = pos1.x;
        float x2 = pos2.x;
        float y1 = pos1.y;
        float y2 = pos2.y;
        if ((Mathf.Abs(x1 - x2) < 0.1f) && (Mathf.Abs(y1 - y2) < 0.1f))
            return true;
        else
            return false;
    }

    public static bool equal(Vector3 pos1, Vector2 pos2, float delta)
    {
        float x1 = pos1.x;
        float x2 = pos2.x;
        float y1 = pos1.y;
        float y2 = pos2.y;
        if ((Mathf.Abs(x1 - x2) < delta) && (Mathf.Abs(y1 - y2) < delta))
            return true;
        else
            return false;
    }

    public static bool equal(float x1, float y1, float x2, float y2)
    {
        if ((Mathf.Abs(x1 - x2) < 0.1f) && (Mathf.Abs(y1 - y2) < 0.1f))
            return true;
        else
            return false;
    }
    */
}
