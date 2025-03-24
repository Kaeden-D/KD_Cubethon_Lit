using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forward_force;
    public float sideway_force;

    private void FixedUpdate()
    {

        rb.AddForce(0, 0, forward_force * Time.deltaTime);

        if(Input.GetKey("d"))
        {

            rb.AddForce(sideway_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a"))
        {

            rb.AddForce(-sideway_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if(rb.position.y < -5f)
        {

            FindObjectOfType<GameManger>().EndGame();

        }

    }

}
