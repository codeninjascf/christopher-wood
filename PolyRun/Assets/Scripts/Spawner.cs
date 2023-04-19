using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float objectSpeed = 8f;

    private List<GameObject> _activeObjects;
    void Start()
    {
        
    }
 
    
    // Update is called once per frame
    void Update()
    {
        Vector3 movement = objectSpeed * Time.deltaTime * Vector3.left;
        foreach (GameObject activeObject in _activeObjects)
        {
            activeObject.transform.position += movement;
        }
        GameManager.UpdateScore(movement);
    }
    IEnumerator Spawn()
    {
        GameManager.UpdateList(_activeObjects);

        GameObject challengeObject = Instantiate(GameManager.GetChallengeObject());
    }
}
