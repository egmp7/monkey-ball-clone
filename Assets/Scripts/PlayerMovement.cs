using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float movementForce;
    [SerializeField]
    Transform cam;
    Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        // Inputs
        float forward = Input.GetAxisRaw("Vertical");
        float side = Input.GetAxisRaw("Horizontal");

        // Camera direction
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;
        camForward.y = 0;
        camRight.y = 0;

        // Relative Positions
        Vector3 forwardRelative = camForward * forward;
        Vector3 rightRelative = camRight * side;

        // Movement
        Vector3 playerMovement = forwardRelative + rightRelative;
        rb.AddForce(playerMovement * movementForce, ForceMode.Force);
    }
}
