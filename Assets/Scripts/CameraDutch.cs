using UnityEngine;
using Cinemachine;

public class CameraDutch : MonoBehaviour
{
    [SerializeField][Range(0.0f, 30.0f)] float dutchMagnitude;
    [SerializeField][Range(0.0f, 4.0f)] float smoothDutchValue;
    
    private CinemachineVirtualCamera cinemachineVirtualCamera;

    private void Awake()
    {
        cinemachineVirtualCamera = gameObject.GetComponent<CinemachineVirtualCamera>();
    }

    void LateUpdate()
    {
        DutchAnimation();
    }

    private void DutchAnimation()
    {
        // get input from user and current dutch value
        float sideInput = Input.GetAxisRaw("Horizontal");
        float currentDutch = cinemachineVirtualCamera.m_Lens.Dutch;

        // Calculate the target dutch value based on input
        float targetDutch = (sideInput < 0) ? dutchMagnitude :
                            (sideInput > 0) ? -dutchMagnitude :
                            0f;

        // Smoothly interpolate between the current dutch value and the target dutch value
        float smoothedDutch = Mathf.Lerp(currentDutch, targetDutch, smoothDutchValue * Time.deltaTime);

        // Apply the smoothed dutch value to the camera lens
        cinemachineVirtualCamera.m_Lens.Dutch = smoothedDutch;
    }
}
