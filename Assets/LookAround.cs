using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAround : MonoBehaviour
{
    public Camera camera;


    void Start()
    {
        camera = FindObjectOfType<Camera>();
    }
    void Update()
    { 
      Ray camRay = new Ray();
      camRay = camera.ScreenPointToRay(Input.mousePosition);
      Plane gplane = new Plane(Vector3.up, Vector3.zero);

      float rayLength;

      if (gplane.Raycast(camRay, out rayLength))
      {
        Vector3 pointToLook = camRay.GetPoint(rayLength);
        Debug.DrawLine(camRay.origin, pointToLook, Color.blue);
        transform.LookAt(new Vector3(pointToLook.x, transform.position.y,pointToLook.z));
      }
    }
}