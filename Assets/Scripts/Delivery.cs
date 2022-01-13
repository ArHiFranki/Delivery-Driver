using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Delivery : MonoBehaviour
{
    [SerializeField] private Color32 hasPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private Color32 noPackageColor = new Color32(1, 1, 1, 1);
    [SerializeField] private float destroyDelay = 0.5f;

    private bool hasPackage;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D()
    {
        //Debug.Log("Collision Enter");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package pick up!");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, destroyDelay);
        }

        if (collision.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
