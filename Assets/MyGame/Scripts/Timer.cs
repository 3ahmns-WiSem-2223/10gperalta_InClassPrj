using TMPro;
using System;
using UnityEngine;


public class Timer : MonoBehaviour

{
    public TextMeshProUGUI timeText;
    public float time;
    public GameObject timeOutText;




    private bool won = false;





    private void Start()
    {
       
        won = false;

    }

    void Update()
    {
        if (time >= 0.0f && !won)
        {
            time -= Time.deltaTime;
        }

        else if (time <= 0.0f && !won)
        {
            timeOutText.SetActive(true);
        }

        var ts = TimeSpan.FromSeconds(time);
        timeText.text = string.Format("{0:00}:{1:00}", ts.Minutes, ts.Seconds);

    }




}

