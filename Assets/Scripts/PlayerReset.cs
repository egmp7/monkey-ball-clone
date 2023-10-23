using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    [SerializeField]
    float deadPosition;
    [SerializeField]
    GameObject vcam;
    Vector3 initPosition;
    Rigidbody rb;
    void Start()
    {
        initPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (transform.position.y < -deadPosition)
        {
            // reset player position and velocity
            Vector3 zero = new Vector3(0, 0, 0);
            rb.velocity = zero;
            rb.angularVelocity = zero;
            transform.position = initPosition;

            // reset camera
            vcam.GetComponent<CameraReset>().ResetCamera();
        }
    }
}
