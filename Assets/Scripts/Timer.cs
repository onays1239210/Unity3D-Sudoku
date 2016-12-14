﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public static float timer = 1 * 60;
    string minutes;
    string seconds;
    float OneSecond = 1;

    Text text;

    void Awake()
    {
        text = GetComponent<Text>();
    }

    void Update()
    {
        OneSecond -= Time.deltaTime;
        if (OneSecond <= 0.00)
        {
            timer -= 1;
            OneSecond = 1;
        }

        minutes = Mathf.Floor(timer / 60).ToString("00");
        seconds = (timer % 60).ToString("00");
        text.text = minutes + ":" + seconds;
    }

    public void SetDefutTimer(float Minutes)
    {
        timer = Minutes * 60;
    }
}
