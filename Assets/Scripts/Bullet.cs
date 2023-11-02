using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform bulletSpawn;
    public GameObject bulletprefab;
    public float speed = 10f;
    
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            var bullet = Instantiate(bulletprefab, bulletSpawn.position, bulletSpawn.rotation);
            bullet.GetComponent<Rigidbody>().velocity =bulletSpawn.forward * speed;
        }
    }
}
