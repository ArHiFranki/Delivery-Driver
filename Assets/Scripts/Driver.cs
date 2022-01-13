using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 300f;
    [SerializeField] private float moveSpeed = 18f;
    [SerializeField] private float slowSpeed = 12f;
    [SerializeField] private float boostSpeed = 22f;

    private void Update()
    {
        float turnAmount = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -turnAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D()
    {
        moveSpeed = slowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "SpeedUp")
        {
            moveSpeed = boostSpeed;
        }
    }
}
