using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthContoller : MonoBehaviour
{
    public int totalHealth = 3;
    public GameObject deathEffect;

    public void DamageEnemy(int damageAmount)
    {
        totalHealth -= damageAmount;

        if (totalHealth <= 0)
        {
            if (deathEffect != null)
            {
                Instantiate(deathEffect, transform.position, transform.rotation);
            }
            Destroy(gameObject);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
