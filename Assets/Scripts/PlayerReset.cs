using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    [SerializeField]
    float deadPosition;
    Vector3 initPosition;
    Rigidbody rb;
    void Start()
    {
        initPosition = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (transform.position.y < -deadPosition)
        {
            //transform.position = initPosition;
        }
    }

    void FixedUpdate()
    {
        if (transform.position.y < -deadPosition)
        {
            Vector3 zero = new Vector3(0, 0, 0);
            rb.velocity = zero;
            rb.angularVelocity = zero;
            transform.position = initPosition;
        }
    }
}
