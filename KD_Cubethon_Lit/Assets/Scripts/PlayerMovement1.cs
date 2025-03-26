using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement1 : MonoBehaviour
{

    public Rigidbody rb;

    public float forward_force;
    public float gravity;
    public float sideway_force;

    private void FixedUpdate()
    {

        rb.AddForce(0, 0, forward_force * Time.deltaTime);
        rb.AddForce(0, -gravity * Time.deltaTime, 0);

        if (Input.GetKey("d") || Input.GetKey("right"))
        {

            rb.AddForce(sideway_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {

            rb.AddForce(-sideway_force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

        }

        if (rb.position.y < -5f)
        {

            FindObjectOfType<GameManger>().EndGame();

        }

    }

}
