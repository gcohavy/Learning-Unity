using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Declaring variables
    [SerializeFIeld] private float speed = 5.0f;
    [SerializeFIeld] private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Update is called once per frame
    void FixedUpdate()
    {
        //Collecting Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move the vehicle forward based on Vertical Input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turn vehicle based on Horizontal Input
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
