using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteBehavior : MonoBehaviour
{
    
    public void LoadNextLevel()
    {

        Debug.Log(SceneManager.sceneCount);
        Debug.Log(SceneManager.GetActiveScene().buildIndex);
        Debug.Log((((SceneManager.GetActiveScene().buildIndex) % SceneManager.sceneCount) + 1));
        SceneManager.LoadScene(((SceneManager.GetActiveScene().buildIndex) % SceneManager.sceneCount) + 1);

    }

    public void InvokeNextLevel(float time)
    {

        Invoke("LoadNextLevel", time);

    }

}
