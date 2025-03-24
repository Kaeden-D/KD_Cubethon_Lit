using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{

    public Transform player;
    public Vector3 offset;

    public bool gameWon = false;

    void Update()
    {
        if(!gameWon)
        {

            transform.position = player.position + offset;

        }

    }

}
