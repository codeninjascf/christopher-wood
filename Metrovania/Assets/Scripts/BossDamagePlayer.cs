using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDamagePlayer : MonoBehaviour
{

    public float bulletSpeed;
    public Rigidbody2D theRB;

    public Vector2 moveDir;

    void Start()
    {
        moveDir = PlayerHealthController.instance.gameObject.transform.position - transform.position;
        moveDir.Normalize();
    }


    void Update()
    {
        theRB.velocity = moveDir * bulletSpeed;
    }
}
