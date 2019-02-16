using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    Rigidbody rb;
    public float speed = 25;
    float hRotation;
    float vRotation;
        
    // Use this for initialization
    void Start ()
    {
            
        rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update ()
    {
        float movementX = Input.GetAxis("Horizontal");
        float movementY = Input.GetAxis("Vertical");
        Vector3 velocity = Vector3.Normalize(transform.forward * movementY + transform.right * movementX);//new Vector3(movementX, 0, movementY);
        velocity.y = 0;
        Vector3 airResistance = rb.velocity;
        if (movementX == 0 && movementY == 0&& System.Math.Abs(rb.velocity.y) < .001)
            airResistance *= 10;
            rb.AddForce(speed*velocity-airResistance);
        if (Input.GetKeyDown(KeyCode.Space)&& System.Math.Abs(rb.velocity.y)<.001)
            rb.AddForce(new Vector3(0, 500, 0));
        CameraUpdate();
	}

    void CameraUpdate()
    {
        hRotation = Input.GetAxis("Mouse X");
        vRotation = Input.GetAxis("Mouse Y");
        transform.Rotate(-vRotation, 0f, 0f, Space.Self);
        transform.Rotate(0f, hRotation, 0f, Space.World);

    }
}
