using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    //public Transform pt;
    public float ForwardForce = 400f;
    public float SidewayForce = 500f;
    public float minY = -1f;


    void FixedUpdate()
    {
        //Add forward force
        rb.AddForce(0, 0, ForwardForce * Time.deltaTime);
        if(Input.GetKey("d"))
        {
            rb.AddForce(SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange );
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-SidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < minY)
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
}
