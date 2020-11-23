using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;

    // FixedUpdate for smooth physics simulation
    void FixedUpdate()
    {
        // Add forward force
        // rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        else if (Input.GetKey("a")) {
            rb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        else if (Input.GetKey("w")) {
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        }

        else if (Input.GetKey("d")) {
            rb.AddForce(0, 0, -(forwardForce) * Time.deltaTime);
        }

        if(rb.position.y < -1f) {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
