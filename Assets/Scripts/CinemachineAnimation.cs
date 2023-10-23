using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineAnimation : MonoBehaviour
{
    [SerializeField]
    float dutchValue;
    CinemachineVirtualCamera cinemachineVirtualCamera;
    // Start is called before the first frame update

    private void Awake()
    {
        cinemachineVirtualCamera = gameObject.GetComponent<CinemachineVirtualCamera>();
    }

    void LateUpdate()
    {
        float sideInput = Input.GetAxisRaw("Horizontal");
        if (sideInput < 0) cinemachineVirtualCamera.m_Lens.Dutch = -dutchValue;
        else if (sideInput > 0) cinemachineVirtualCamera.m_Lens.Dutch = dutchValue;
        else cinemachineVirtualCamera.m_Lens.Dutch = 0f;
    }
}
