using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
            // Get the mouse axes
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            // Move the camera based on the mouse movement
            transform.RotateAround(transform.position, Vector3.up, mouseX  );
            transform.RotateAround(transform.position, transform.right, -mouseY  );
        }


    }
}
