using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        if (rb != null)
        {
            rb.velocity = transform.forward * speed;
        }
    }

    private void FixedUpdate()
    {
        // Optional: Add any additional bullet behavior here
    }

    private void OnDisable()
    {
        if (rb != null)
        {
            rb.velocity = Vector3.zero; // Reset velocity when deactivated
        }
    }
}
