using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{

    public LevelCompleteBehavior level_complete;

    public void Complete_Restart()
    {

        Debug.Log("Game Restarted");
        level_complete.InvokeNextLevel(0.2f);

    }

}
