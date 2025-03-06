using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickController : MonoBehaviour
{
    public Rigidbody StickGolf;
    float speed = 15f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    if(Input.GetKeyDown(KeyCode.UpArrow)){
        StickGolf.transform.Translate(Vector3.left * speed*Time.deltaTime);
    }
    if(Input.GetKeyDown(KeyCode.DownArrow)){
        StickGolf.transform.Translate(Vector3.right * speed*Time.deltaTime);
    }
    if(Input.GetKeyDown(KeyCode.LeftArrow)){
        StickGolf.transform.Translate(Vector3.up * speed*Time.deltaTime);
    }
    if(Input.GetKeyDown(KeyCode.RightArrow)){
        StickGolf.transform.Translate(Vector3.down * speed*Time.deltaTime);
    }
    }
}
