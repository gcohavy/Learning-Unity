using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30.0f;
    private float bottomBound = -10.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Destroy objects that leave the screen
        if( transform.position.z > topBound )
        {
            Destroy(gameObject);
        } else if ( transform.position.z < bottomBound )
        {
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
