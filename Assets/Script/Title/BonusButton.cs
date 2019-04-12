using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BonusButton : MonoBehaviour {

    int count = 0;

    public void PushButton()
    {
        count++;
        if(count>=20)
        {
            SceneChangeManager.SceneChange(4);
        }
    }
}
