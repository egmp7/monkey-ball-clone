using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CinemachineVirtualCamera))]
public class CinemachineAnimation : MonoBehaviour
{
    [SerializeField]
    float dutchValue;
    [SerializeField]
    float smoothDutch;
    CinemachineVirtualCamera cinemachineVirtualCamera;

    private void Awake()
    {
        cinemachineVirtualCamera = gameObject.GetComponent<CinemachineVirtualCamera>();
    }

    void LateUpdate()
    {
        float sideInput = Input.GetAxisRaw("Horizontal");
        float currentDutch = cinemachineVirtualCamera.m_Lens.Dutch;
        if (sideInput < 0) cinemachineVirtualCamera.m_Lens.Dutch = Mathf.Lerp(dutchValue,currentDutch,smoothDutch);   
        else if (sideInput > 0) cinemachineVirtualCamera.m_Lens.Dutch = Mathf.Lerp(-dutchValue,currentDutch,smoothDutch);
        else cinemachineVirtualCamera.m_Lens.Dutch = Mathf.Lerp(0,currentDutch,smoothDutch);
    }
}
