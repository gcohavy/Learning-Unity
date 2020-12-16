using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    [SerializeFIeld] private Vector3 offset = new Vector3(0,5,-7);

    // Update is called once per frame
    void LateUpdate()
    {
        //Offset camera from player's position
        transform.position = player.transform.position + offset;
    }
}
