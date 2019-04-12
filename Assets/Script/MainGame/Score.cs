using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class Score
{

    private static int HighScore;
    private static int NowScore;

    static string key = "HIGH SCORE";

    void Start()
    {
        HighScore = PlayerPrefs.GetInt(key, 0);
    }

    public static void ReadHighScoreTime()
    {
        HighScore = PlayerPrefs.GetInt(key, 0);
    }

    public static float GetHighScoreTime()
    {
        return HighScore;
    }

    public static float GetNowScoreTime()
    {
        return NowScore;
    }
    public static void SetScoreTime(float time)
    {
        NowScore = (int)time;
        if (time < HighScore)
        {
            HighScore = (int)time;
            PlayerPrefs.SetInt(key, HighScore);
        }
    }

}
