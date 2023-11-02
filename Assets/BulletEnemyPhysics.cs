using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletEnemyPhysics : MonoBehaviour
{
    public float life  = 3f;
    public float time = 3f;

    
    void OnCollisionEnter(Collision collision) 
    {
       if (collision.gameObject.tag == "Player"){
             Destroy(collision.gameObject);    
       }
       Destroy(gameObject);
    }
    
}
