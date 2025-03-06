using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    // Start is called before the first frame update
      public GameObject winScript;
    ShootBall shootBall;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetMouseButtonDown(0)){
            
        }
    }
    void OnTriggerExit(Collider other)
    {
      
        if(other.gameObject.tag=="Ball")
        {
           shootBall.PuntosGolpeo=0;
            winScript.GetComponent<Win>().MoveBallToSpawn();
            
        }
    }
}
