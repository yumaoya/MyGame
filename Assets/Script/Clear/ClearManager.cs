﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearManager : MonoBehaviour
{

    [SerializeField]
    private GameObject[] PlayerStand;
    [SerializeField]
    private GameObject[] PlayerRunning;
    [SerializeField]
    private int JumpNum = 10;

    [SerializeField]
    private Text NowScore;

    [SerializeField]
    private Text HighScore;

    private int index;
    private bool isJump = false;
    private float timeOut = 0.25f;
    private float time;

    // Use this for initialization
    void Start()
    {
        index = SelectStageStatus.PlayerNum + SelectStageStatus.StageNum - 1;

        PlayerStand[index].SetActive(true);


        Score.ReadHighScoreTime();

        NowScore.text = Score.GetNowScoreTime().ToString() + "秒";
        HighScore.text = Score.GetHighScoreTime().ToString() + "秒";
    }

    // Update is called once per frame
    void Update()
    {
        if (JumpNum <= 0) return;

        time += Time.deltaTime;

        // timeOutごとに実行
        if (time >= timeOut)
        {
            time = 0.0f;
            JumpNum--;

            if (isJump)
            {
                isJump = false;
                PlayerStand[index].SetActive(true);
                PlayerRunning[index].SetActive(false);
            }
            else
            {
                isJump = true;
                PlayerStand[index].SetActive(false);
                PlayerRunning[index].SetActive(true);
            }
        }
    }
}
