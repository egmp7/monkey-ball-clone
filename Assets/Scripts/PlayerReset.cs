using UnityEngine;

public class PlayerReset : MonoBehaviour
{
    [SerializeField] float deadPosition;
    [SerializeField] GameObject vcam;
    
    private Vector3 _initPos;
    private Rigidbody _rb;

    void Start()
    {
        _initPos = transform.position;
        _rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        if (transform.position.y < -deadPosition)
        {
            // reset player position and velocity
            Vector3 zero = new Vector3(0, 0, 0);
            _rb.velocity = zero;
            _rb.angularVelocity = zero;
            transform.position = _initPos;

            // reset camera
            vcam.GetComponent<CameraReset>().ResetCamera();
        }
    }
}
