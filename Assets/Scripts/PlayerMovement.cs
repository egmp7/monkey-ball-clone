using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
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

        // Create Force
        Vector3 forwardForce = new Vector3(0, 0, forward) * forwardMagnitude;
        Vector3 sideForce = new Vector3(side, 0, side) * sideMagnitude;

        // Movement
        _rb.AddForce(forwardForce);
        _rb.AddForce(sideForce);
    }
}
