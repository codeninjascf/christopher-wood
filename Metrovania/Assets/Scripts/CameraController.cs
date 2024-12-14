using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    
    private PlayerControleer player;


    void Start()
    {
        player = FindObjectOfType<PlayerControleer>();  
    }

    
    
    
    // Update is called once per frame
    void Update()
    {
       if(player != null)
       {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, transform.position.z);
       } 
    }
}
