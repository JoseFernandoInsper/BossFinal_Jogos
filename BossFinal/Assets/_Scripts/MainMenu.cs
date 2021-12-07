using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using TMPro;

public class MainMenu : MonoBehaviour
{

    
    public TextMeshProUGUI timeCouterHS;
    public TimeSpan timePlaying;
    

    void Start(){

        //timeCouterHS.GetComponent<TextMeshProUGUI>();
        
    }

    void Update(){
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
