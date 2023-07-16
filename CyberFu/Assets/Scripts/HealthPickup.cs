using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    public int healAmount = 2;
    public float rotateSpeed = 50f;
    void Start()
    {
        
    }

    



    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<PlayerHealth>().Add(healAmount);

            Destroy(gameObject);
        }
    }
}
