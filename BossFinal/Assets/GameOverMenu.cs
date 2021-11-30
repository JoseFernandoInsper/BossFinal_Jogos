using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    public void RePlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-2);
    }
    public void GoToMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-3);
    }
}
