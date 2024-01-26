using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Note : MonoBehaviour
{
    public float speed;

    [SerializeField] Rigidbody2D rb;

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.up * speed * Time.deltaTime;
    }
}
