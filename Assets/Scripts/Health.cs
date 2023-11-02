using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float Strikes = 3;
    
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "EnemyBullet")
        {
            Strikes --;
        }
        
    }
}
