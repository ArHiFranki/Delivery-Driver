using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    private void OnCollisionEnter2D()
    {
        Debug.Log("Collision Enter");
    }
}
