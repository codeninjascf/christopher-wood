using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float jumpForce = 7f;

    private Rigidbody2D rigidbody;
    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        rigidbody.velocity = Vector2.zero;
        rigidbody.AddForce(jumpForce * Vector2.up, ForceMode2D.Impulse);
    }
}
