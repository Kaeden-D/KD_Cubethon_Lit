using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManger : MonoBehaviour
{

    bool gameOver = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel()
    {

        completeLevelUI.SetActive(true);

    }
    
    public void EndGame()
    {

        if (!gameOver)
        {

            gameOver = true;
            Debug.Log("GameOver");
            Invoke("Restart", restartDelay);

        }

    }

    void Restart()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
        
}
