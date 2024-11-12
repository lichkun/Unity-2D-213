using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    [SerializeField]
    private float levelTimeout = 15f; //seconds
    private TMPro.TextMeshProUGUI clockTMP;
    private float gameTime;

    // Start is called before the first frame update
    void Start()
    {
        clockTMP = GameObject.Find("ClockTMP").GetComponent<TMPro.TextMeshProUGUI>();
        gameTime = 0f;
    } 

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
        TimeSpan timeSpan = TimeSpan.FromSeconds(gameTime);

        if (clockTMP != null)
        {
            clockTMP.text = string.Format("{0:D2}:{1:D2}:{2:D2}.{3:D1}",
                timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds, (int)(timeSpan.Milliseconds / 100));
        }
        if(gameTime >= levelTimeout)
        {
            GameState.Pause("Time is out");
        }
    }
}