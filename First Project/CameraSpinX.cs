using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSpinX : MonoBehaviour
{
    //Declare Variables
    public float propellorSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Spin the propellor based on the propellor speed
        transform.Rotate(Vector3.right, Time.deltaTime * propellorSpeed);
    }
}
