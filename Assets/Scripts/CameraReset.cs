using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraReset : MonoBehaviour
{
    CinemachineVirtualCamera vcam;
    Vector3 _initPos;
    Quaternion _initRot;

    private void OnEnable()
    {
        EventManager.onPlayerDeath += ResetCamera;
    }
    private void OnDisable()
    {
        EventManager.onPlayerDeath -= ResetCamera;
    }

    private void Start()
    {
        vcam = gameObject.GetComponent<CinemachineVirtualCamera>();
        _initPos = vcam.transform.position;
        _initRot = vcam.transform.rotation;
    }

    private void ResetCamera()
    {
        vcam.enabled = false;
        vcam.transform.SetPositionAndRotation(_initPos, _initRot);
        vcam.enabled = true;
    }

}
