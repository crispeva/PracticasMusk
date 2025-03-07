using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    private Win win;
      public float rango = 5.0f;
      float velocidad = 1f;

    void Awake()
    {
        win=FindAnyObjectByType<Win>();
    }
    // Update is called once per frame
    void Update()
    {
        Move();
        Move();
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Ball"){
            win.MoveBallToSpawn();
        }
    }
    void Move()
    {
        transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        
        if (transform.position.x > rango)
        {
            transform.position = new Vector3(-rango, transform.position.y, transform.position.z);
        }
    }

}
