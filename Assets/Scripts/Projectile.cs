using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Projectile : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public float destroyTime = 2.0f; 

    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void Update()
    {
        Destroy(gameObject, destroyTime);
    }

    void OnTriggerEnter2D (Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            Destroy(gameObject);
        }
    }
}