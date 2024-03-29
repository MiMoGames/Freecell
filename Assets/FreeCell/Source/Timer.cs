﻿using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float minutes = 0f;
    float seconds = 0f;
    float milliseconds = 0f;
    string minutesS ;
    string secondsS ;
    string millisecondsS;
    public Text textBox;
    
    void Update()
    {

        if (milliseconds >= 100)
        {
            if (seconds >= 59)
            {
                minutes++;
                seconds = 0;
            }
            else if (seconds < 59)
            {
                seconds++;
            }
            milliseconds = 0;
        }
        milliseconds += Time.deltaTime * 100;
        if (minutes < 10)
        {
            minutesS = "0" +minutes;
        }
        else
        {
            minutesS = "" +minutes;
        }

        if (seconds < 10)
        {
            secondsS = "0" +seconds;
        }
        else
        {
            secondsS = "" +seconds;
        }

        if ((int)milliseconds < 10)
        {
            millisecondsS = "0" +(int)milliseconds;
        }
        else
        {
            millisecondsS = "" +(int)milliseconds;
        }
        textBox.text = minutes.ToString("00") + ":" + seconds.ToString("00");
//        Debug.Log(string.Format("{ 0}:{ 1}:{ 2}", minutesS, secondsS, millisecondsS));
    }
}