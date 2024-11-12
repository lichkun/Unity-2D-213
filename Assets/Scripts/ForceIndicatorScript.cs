using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ForceIndicatorScript : MonoBehaviour
{
    public static float forceFactor;

    [SerializeField]
    private Image indicatorFg;



    [SerializeField]
    private float sensitivity = 0.01f;
    void Start()
    {
        forceFactor = indicatorFg.fillAmount;
    }

    // Update is called once per frame
    void Update()
    {
        float dx = Input.GetAxis("Horizontal");
        if (dx != 0)
        {
            dx *= sensitivity;
            if (0.1f < indicatorFg.fillAmount + dx && indicatorFg.fillAmount < 1.0f)
            {
                forceFactor = indicatorFg.fillAmount += dx;
            }
        }
    }
}