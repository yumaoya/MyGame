using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoolISVisible : MonoBehaviour
{

    private void Start()
    {

    }
    void OnBecameVisible()
    {
        StopClass.Stop = true;

        StartCoroutine("Visible");

    }

    private IEnumerator Visible()
    {

        yield return new WaitForSeconds(2f);

        //クリア
        if (SelectStageStatus.StageNum != (int)SceneChangeManager.Scenes.BonusStage)
            SceneChangeManager.SceneChange(SceneChangeManager.Scenes.Clear);
        else
            SceneChangeManager.SceneChange(SceneChangeManager.Scenes.Title);
    }
}
