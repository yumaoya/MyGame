using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearButtonScript : MonoBehaviour
{

    public void RetryButton()
    {
        SceneChangeManager.SceneChange();
    }

    public void HomeButton()
    {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.Title);
    }
}
