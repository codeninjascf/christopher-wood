using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    private PlayerControleer player;
    public BoxCollider2D boundsBox;

    private float halfHeight, halfWidth;


    void Start()
    {
        player = FindObjectOfType<PlayerControleer>();

        halfHeight = Camera.main.orthographicSize;
        halfWidth = halfHeight * Camera.main.aspect;
    }

    
    
    
    // Update is called once per frame
    void Update()
    {
       if(player != null)
       {
            transform.position = new Vector3(
                Mathf.Clamp(player.transform.position.x, boundsBox.bounds.min.x + halfWidth, boundsBox.bounds.max.x - halfWidth),
                Mathf.Clamp(player.transform.position.y, boundsBox.bounds.min.y + halfHeight, boundsBox.bounds.max.y - halfHeight),
                transform.position.z);
       } 
    }
}
