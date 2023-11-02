using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhysicsBullet : MonoBehaviour
{
    public float life  = 3f;
    public float time = 3f;
    public float  enemies = 3f;
    public GameObject screen;
   
    void awake()
    {
        Destroy(gameObject , life);
    }
    void OnCollisionEnter(Collision collision) 
    {
       if (collision.gameObject.tag == "Enemy"){
             Destroy(collision.gameObject);  
             enemies = enemies - 1; 
       }
       Destroy(gameObject);
    }
    void Update(){
        if (enemies == 0){
        screen.SetActive(true);
    }
    }
}
