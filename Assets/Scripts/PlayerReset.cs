using UnityEngine;

public class PlayerReset : MonoBehaviour
{   
    private Vector3 _initPos;
    private Quaternion _initRot;
    private Rigidbody _rb;

    private void OnEnable()
    {
        EventManager.onPlayerDeath += ResetPlayerPosition;
    }
    private void OnDisable()
    {
        EventManager.onPlayerDeath -= ResetPlayerPosition;
    }

    private void Start()
    {
        _initPos = transform.position;
        _initRot = transform.rotation;
        _rb = GetComponent<Rigidbody>();
    }

    private void ResetPlayerPosition()
    {
        _rb.velocity = Vector3.zero;
        _rb.angularVelocity = Vector3.zero;
        transform.position = _initPos;
        transform.rotation = _initRot;
    }
}