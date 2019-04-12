using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class SceneChangeManager
{

    public enum Scenes
    {
        Title = 0,
        MainGame,
        MainGame2,
        MainGame3,
        BonusStage,
        GameOver,
        Clear,
        End
    }

    private static int NowScene = 0;

    public static void SceneChange(Scenes scene)
    {

        if (Scenes.End == scene)
        {
            Application.Quit();
        }

        SceneManager.LoadScene(scene.ToString());
    }

    public static void SceneChange(int num)
    {

        var enmVal = (Scenes)Enum.ToObject(typeof(Scenes), num);

        NowScene = num;

        SelectStageStatus.StageNum = NowScene;

        SceneManager.LoadScene(enmVal.ToString());

    }

    public static void SceneChange()
    {
        var enmVal = (Scenes)Enum.ToObject(typeof(Scenes), NowScene);

        SceneManager.LoadScene(enmVal.ToString());

    }
}