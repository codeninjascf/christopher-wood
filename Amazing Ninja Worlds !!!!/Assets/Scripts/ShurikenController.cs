using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShurikenController : MonoBehaviour
{
    public float speed = 8;
    public float despawnTime = 3;

    private int _direction;

    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position += despawnTime.deltaTime * _direction
            * speed * Vector3.right;
    }

    public void Initialise(int direction)
    {
        _direction = direction;

        GetComponent<Animator>().SetInteger("Direction", direction);

        Destroy(gameObject, despawnTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Hazard") || other.CompareTag("Platform"))
        {
            Destroy(gameObject);
        }
    }

}
