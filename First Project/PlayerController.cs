using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    //Declaring variables
    [SerializeFIeld] float speed;
    [SerializeFIeld] float rpm;
    [SerializeFIeld] float horsePower;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;
    [SerializeField] GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    [SerializeField] List<WheelCollider> allWheels;

    // Start is called once at the very beginning
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Collecting Player Input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        if(IsOnGround())
        {
            //move the vehicle forward based on Vertical Input
            //transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
            playerRb.AddRelativeForce(Vector3.forward * forwardInput * horsePower);

            //Turn vehicle based on Horizontal Input
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

            //Calculate and set speed
            speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f); //3.6 for kph
            speedometerText.SetText("Speed: " + speed + "mph");

            //Calculate and set RPM
            rpm = Mathf.Round((speed%30) * 40);
            rpmText.SetText("RPM: " + rpm);
        }
    }

    bool IsOnGround()
    {
        int wheelsOnGround = 0;
        foreach(WheelCollider wheel in allWheels)
        {
            if(wheel.isGrounded)
            {
                wheelsOnGround++;
            }
        }

        if(wheelsOnGround == 4)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
