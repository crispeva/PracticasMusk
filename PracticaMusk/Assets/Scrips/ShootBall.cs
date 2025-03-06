using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
//Public Attributes
    public Rigidbody ball;
    public StickController stickController;
    float Distance ;
    float TimeBall;
    bool isShoot=false;
    public int PuntosGolpeo=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }
void Update(){
  
        Distance = Vector3.Distance(ball.transform.position, stickController.StickGolf.transform.position);
        Vector3 directionToBall = (ball.transform.position - stickController.StickGolf.transform.position).normalized;

        if(Input.GetMouseButtonDown(0)& isShoot==false)
        {
            ball.isKinematic=false;
            Vector3 direction = (ball.transform.position - stickController.StickGolf.transform.position).normalized;
            ball.GetComponent<Rigidbody>().AddForce(direction * Distance * 200);
            PuntosGolpeo++;
            print("Puntos de Golpeo: "+PuntosGolpeo);
            TimeBall=Time.time;
           isShoot=true;
        }
        if(Time.time-TimeBall>3 && isShoot==true){
               print("Time is over"+TimeBall);
               stickController.StickGolf.transform.position=new Vector3(0,0,0);
              ball.isKinematic=true;
               TimeBall=0; 
               isShoot=false;

                 MoveStickToBall(directionToBall);


        }
}
  void MoveStickToBall(Vector3 Distance)
    {
     

        // Coloca el palo a una distancia constante del balón
          stickController.StickGolf.transform.position = new Vector3(
          ball.transform.position.x , 
          stickController.StickGolf.transform.position.y,
          ball.transform.position.z
           
      );      
        
    }
  
}
