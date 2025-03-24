using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerBehavior : MonoBehaviour
{

    public GameManger gameManager;
    public ScoreBehavior scoreBehavior;
    public LevelCompleteBehavior levelCompleteBehavior;
    public CameraBehavior cameraBehavior;

    private void OnTriggerEnter()
    {

        scoreBehavior.textChange(false);
        cameraBehavior.gameWon = true;
        gameManager.CompleteLevel();
        levelCompleteBehavior.InvokeNextLevel(3f);

    }

}
