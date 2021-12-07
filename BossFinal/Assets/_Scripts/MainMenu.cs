using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class MainMenu : MonoBehaviour
{

    TextMeshProUGUI timeCouterHS;
    public TimeSpan timePlaying;

    public void Start(){

        timePlaying = TimeSpan.FromSeconds(PlayerPrefs.GetFloat("Highscore", 0f));
        string temp = timePlaying.ToString("mm':'ss'.'ff");
        timeCouterHS.text = $"HighScore: {temp}";
    }
    public void PlayGame()
    {
        PlayerPrefs.SetFloat("score", 0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
