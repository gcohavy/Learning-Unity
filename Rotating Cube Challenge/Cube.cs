using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    //Declare change variables
    private Vector3 cubePosition = new Vector3(0,0,0);
    public float rotationSpeedX = 15.0f;

    void Start()
    {
        float greenScale = Random.Range(0,1.0f);

        transform.position = cubePosition;
        transform.localScale = Vector3.one * 1.6f;
        
        Material material = Renderer.material;
        
        material.color = new Color(0.5f, greenScale, 0.3f, 1.0f);
    }
    
    void Update()
    {
        transform.Rotate(rotationSpeedX * Time.deltaTime, 0.0f, 0.0f);
    }
}
