using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2 : MonoBehaviour
{

    public Rigidbody rb;

    public float forward_force;
    public float gravity;
    public float vertical_force;

    private void FixedUpdate()
    {

        rb.AddForce(0, 0, forward_force * Time.deltaTime);
        rb.AddForce(gravity * Time.deltaTime, -0.075f, 0);

        if (Input.GetKey("w") || Input.GetKey("up"))
        {

            rb.AddForce(0, vertical_force * Time.deltaTime, 0, ForceMode.VelocityChange);

        }

        if (Input.GetKey("s") || Input.GetKey("down"))
        {

            rb.AddForce(0, -vertical_force * Time.deltaTime, 0, ForceMode.VelocityChange);

        }

        if (rb.position.x > 15.5f)
        {

            FindObjectOfType<GameManger>().EndGame();

        }

    }

}
