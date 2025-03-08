using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Win : MonoBehaviour
{
     public GameObject shootBall;
     private Vector3 spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        spawnPosition=shootBall.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
       
    }
   void  OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Ball")
        {
            print("You Win");
            
            MoveBallToSpawn();
        }
    }

    public void MoveBallToSpawn()
    {
        shootBall.transform.position=spawnPosition;
        
    }
}
