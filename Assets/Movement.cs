using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{   
   public CharacterController Controller;

   public float speed = 12f;


   public float multiplier = 0.2f;

   public float cd = 1f;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        float z = Input.GetAxis("Vertical");

        Vector3 pos = transform.right * x + transform.forward * z;
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Controller.Move(pos * (speed + (speed * multiplier )) * Time.deltaTime);
            
        }
        else
        {
            Controller.Move(pos * speed * Time.deltaTime);
        }
    }
}
