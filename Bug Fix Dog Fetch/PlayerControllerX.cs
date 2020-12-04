using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private bool spam;

    private float spamReload = 1;

    void Start()
    {
        spam = false;
    }
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && !spam)
        {
            spam = true;
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            Invoke("SpamFalse", spamReload);
        }
    }

    //Create method to set spam back to false
    void SpamFalse()
    {
        spam = false;
    }
}
