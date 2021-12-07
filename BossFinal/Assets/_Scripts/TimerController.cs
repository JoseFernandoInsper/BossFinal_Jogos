using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class TimerController : MonoBehaviour
{
    TextMeshProUGUI timeCouter;
    private float elapsedTime = 0;
    public TimeSpan timePlaying;

    void Start()
    {
        timeCouter = GetComponent<TextMeshProUGUI>();
        elapsedTime = PlayerPrefs.GetFloat("score", 0);
    }

    void Update()
    { 
        elapsedTime += Time.deltaTime;
        timePlaying = TimeSpan.FromSeconds(elapsedTime);
        string temp = timePlaying.ToString("mm':'ss'.'ff");
        timeCouter.text = $"Tempo: {temp}";
        if(elapsedTime > PlayerPrefs.GetFloat("score", 0f)){
            PlayerPrefs.SetFloat("score", elapsedTime);
        }
        
    }
}
