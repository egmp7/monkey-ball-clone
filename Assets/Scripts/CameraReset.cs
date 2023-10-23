using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CameraReset : MonoBehaviour
{
    CinemachineVirtualCamera vcam;
    Vector3 initPosition;
    Quaternion initRotation;

    private void Awake()
    {
        vcam = gameObject.GetComponent<CinemachineVirtualCamera>();
        initPosition = vcam.transform.position;
        initRotation = vcam.transform.rotation;
    }

    public void ResetCamera()
    {
        vcam.enabled = false;
        vcam.transform.SetPositionAndRotation(initPosition, initRotation);
        vcam.enabled = true;
    }
}
