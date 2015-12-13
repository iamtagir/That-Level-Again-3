using UnityEngine;
using System.Collections;

public class LocScr{

    public static string language = "English";
    public static Vector3 startPos = new Vector3(-1, 2, 0);
    private static string [] text = new string[1000];

    public static void setLaguage(string newLang)
    {
        if (newLang == "English")
        {
            text[0] = "START";
            text[1] = "LET'S            THE GAME";
            text[2] = "OK.";
            text[3] = "ПЛОХОЙ ВЫБОР";
            text[4] = "СОЙДЕТ...";
            text[5] = "ПОПРОБУЙ ЕЩЕ";
            text[6] = "ТЫ НАВЕРНОЕ ХОЧЕШЬ" + '\n' + "УПРАВЛЯТЬ ПЕРСОНАЖЕМ";
            text[7] = "ВОТ ТЕБЕ КНОПКА";
            text[8] = "ХА ХА" + '\n' + "ТЫ КАК ОБЕЗЬЯНКА";
            text[9] = "ОЙ. Я И ЗАБЫЛ ПРО ЭТО" + '\n' + "БЕРИ";
            text[10] = "ОСТАЛАСЬ ЕЩЕ ОДНА КНОПКА";
            text[11] = "ГДЕ ТО Я ВИДЕЛ ПОХОЖУЮ";
            text[12] = "ТЫ СУПЕР СЫЩИК!";
            startPos = new Vector3(-1, 3, 0);
        }
        else if (newLang == "Russian")
        {
            text[0] = "НАЧНЕМ";
            text[1] = "ДАВАЙ              ИГРУ";
            text[2] = "ХОРОШО. НО НАМ НАДО" + '\n' +  " ПОМЕНЯТЬ ЗАДНИЙ ФОН";
            text[3] = "ПЛОХОЙ ВЫБОР";
            text[4] = "СОЙДЕТ...";
            text[5] = "ПОПРОБУЙ ЕЩЕ";
            text[6] = "ТЫ НАВЕРНОЕ ХОЧЕШЬ" + '\n' + "УПРАВЛЯТЬ ПЕРСОНАЖЕМ";
            text[7] = "ВОТ ТЕБЕ КНОПКА";
            text[8] = "ХА ХА" + '\n' + "ТЫ КАК ОБЕЗЬЯНКА";
            text[9] = "ОЙ. Я И ЗАБЫЛ ПРО ЭТО" + '\n' + "БЕРИ";
            text[10] = "ОСТАЛАСЬ ЕЩЕ ОДНА КНОПКА";
            text[11] = "ГДЕ ТО Я ВИДЕЛ ПОХОЖУЮ";
            text[12] = "ТЫ СУПЕР СЫЩИК!";

            startPos = new Vector3(0.45f, 3, 0);
        }
    }

    public static string getText(int id)
    {
        return text[id];
    }


}
