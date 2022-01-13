using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D()
    {
        Debug.Log("Collision Enter");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("On Trigger Enter");
    }
}
