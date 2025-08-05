using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class BossBattle : MonoBehaviour
{
    private CameraController theCam;
    public UnityEngine.Transform camPosition;
    public float camSpeed;
    public float bossSpeed = 5;
    public GameObject fireball;

    private Vector3 enemyPosition;
    private Vector3 startLoc;
    public float areaWidth = 15;
    public float areaHeight = 8;

    void Start()
    {
        startLoc = transform.position;
        theCam = FindObjectOfType<CameraController>();
        theCam.enabled = false;
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        theCam.transform.position = Vector3.MoveTowards(theCam.transform.position, camPosition.position, camSpeed * Time.deltaTime);
        MoveToNewPosition();


    }


    IEnumerator Move()
    {
        while (true)
        {
            for(int i = 0; i < 10; i++)
            {
                GetNewPosition();
                FireBall();
                yield return new WaitForSeconds(1);
            }
            yield return new WaitForSeconds(5);
        }
    }

    private void FireBall()
    {
        Instantiate(fireball, transform.position, Quaternion.identity);
    }

    private void GetNewPosition()
    {
        enemyPosition = startLoc + new Vector3(Random.Range(-areaWidth, areaWidth), Random.Range(-areaHeight, areaHeight), 0);
    }

    private void MoveToNewPosition()
    {
        transform.position = Vector3.MoveTowards(transform.position, enemyPosition, bossSpeed * Time.deltaTime);
    }

    public void EndBattle()
    {
        gameObject.SetActive(false);
    }


}
