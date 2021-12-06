using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelLoader : MonoBehaviour
{

    public Animator transition;
    public float waitTime = 1;
    
    void Update()
    {
        //loadNextLevel();
    }

    public void loadNextLevel(){
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex+1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(waitTime);

        SceneManager.LoadScene(levelIndex);
    }
}
