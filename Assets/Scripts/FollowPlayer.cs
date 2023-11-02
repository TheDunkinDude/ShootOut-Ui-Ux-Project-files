using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 cp;
    void Start()
    {
        cp = this.transform.position;
    }
    void Update()
    {
         transform.position = player.transform.position + cp;
    }
}
