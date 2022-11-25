using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 1f;
    [SerializeField] float moveSpeed = 13f; 
    [SerializeField] float slowSpeed = 8f; 
    [SerializeField] float boostSpeed = 17f;

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmout = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmout, 0);
    }

    void OnCollisionEnter2D(Collision2D other) 
        {
            moveSpeed = slowSpeed; 
        }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "SpeedUp") {
            moveSpeed = boostSpeed;
        }
    }
}
