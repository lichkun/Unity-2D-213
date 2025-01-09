using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    private TMPro.TextMeshProUGUI clockTMP;
    private float gameTime;

    void Start()
    {
        clockTMP = GameObject.Find("DisplayCanvasClockTMP").GetComponent<TMPro.TextMeshProUGUI>();
        gameTime = 0f;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        TimeSpan timeSpan = TimeSpan.FromSeconds(gameTime);

        if (clockTMP != null)
        {
            clockTMP.text = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D1}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, (int)(timeSpan.Milliseconds / 100));
        }
    }
}