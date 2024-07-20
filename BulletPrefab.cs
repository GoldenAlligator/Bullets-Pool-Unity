using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    private float lifetime = 5f;
    private float lifeTimer;
    private Rigidbody rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void OnEnable()
    {
        lifeTimer = lifetime;
    }

    void Update()
    {
        lifeTimer -= Time.deltaTime;
        FlowOfTheBullet();
        if (lifeTimer <= 0f)
        {
            gameObject.SetActive(false); // Only deactivate, do not destroy
        }
    }

    void FlowOfTheBullet()
    {
        if (rb != null)
        {
            Vector3 playerForward = Camera.main.transform.forward; // Use the player's facing direction
            rb.velocity = playerForward.normalized * 400f; // Adjust speed as necessary
        }
    }

    void OnDisable()
    {
        if (rb != null)
        {
            rb.velocity = Vector3.zero; // Reset velocity when deactivated
        }
    }
}
