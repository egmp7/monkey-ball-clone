using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Camera Reference")]
    [SerializeField] Transform cam;
    [Tooltip("Force applied for foward player movement")]
    [SerializeField][Range(1.0f, 10.0f)] float forwardMagnitude;
    [Tooltip("How much force applied for side player movement")]
    [SerializeField][Range(1.0f, 10.0f)] float sideMagnitude;

    private Rigidbody _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        // Inputs
        float forward = Input.GetAxisRaw("Vertical");
        float side = Input.GetAxisRaw("Horizontal");

        // Get Camera direction
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;
        camForward.y = 0;
        camRight.y = 0;

        // Create Force
        Vector3 forwardForce = camForward * forwardMagnitude * forward;
        Vector3 sideForce = camRight * sideMagnitude * side;

        // Movement
        _rb.AddForce(forwardForce);
        _rb.AddForce(sideForce);
    }
}
