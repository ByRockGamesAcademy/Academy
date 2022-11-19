using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainCamera
{
 public class CameraController : MonoBehaviour
 {
    [Header("Camera Settings")]
    [SerializeField]private CameraSettings CameraSettings;

    [Header("Player Target")]
    [SerializeField]private Transform Target;

    private Vector3 CurrentVelocity = Vector3.zero;
    private void Awake() 
    {
       CameraSettings.Offset = transform.position - Target.position;
    }

    private void LateUpdate() 
    {
       Vector3 targetPosition = Target.position + CameraSettings.Offset;
       transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref CurrentVelocity, CameraSettings.SmoothTime);
    }
 }
}
