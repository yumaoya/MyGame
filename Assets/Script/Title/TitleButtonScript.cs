using UnityEngine;
using UnityEngine.UI;

public class TitleButtonScript : MonoBehaviour
{

    public void BeginButton()
    {
       var num= Random.Range((int)SceneChangeManager.Scenes.MainGame, (int)SceneChangeManager.Scenes.BonusStage);
        SceneChangeManager.SceneChange(num);
    }

    public void EndButton()
    {
        SceneChangeManager.SceneChange(SceneChangeManager.Scenes.End);
    }
}
