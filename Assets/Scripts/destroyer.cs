using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    Rigidbody2D rb;

    public bool flip;

    public float jumpForce = 1f;

    public int health = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (health < 1)
        {
            Destroy(gameObject);
        }
    }
}
