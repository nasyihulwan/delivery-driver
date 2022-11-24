using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // this thing position (camera) should be same as the car position

    // Update is called once per frame
    void Update()
    {
        transform.position = thingToFollow.transform.position;
    }
}
