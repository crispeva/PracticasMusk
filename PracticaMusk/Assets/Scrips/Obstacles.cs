using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject win;
    public GameObject Obtecle;
     public GameObject Obtecle2;
      public float rango = 5.0f;
      float velocidad = 1f;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Move(Obtecle);
        Move(Obtecle2);
       
    }

    void Move(GameObject Obtecle)
    {
        Obtecle.transform.Translate(Vector3.right * velocidad * Time.deltaTime);
        
        if (Obtecle.transform.position.x > rango)
        {
            Obtecle.transform.position = new Vector3(-rango, Obtecle.transform.position.y, Obtecle.transform.position.z);
        }
    }

}
