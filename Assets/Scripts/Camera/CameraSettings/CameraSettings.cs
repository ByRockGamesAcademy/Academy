using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MainCamera
{
 [CreateAssetMenu (fileName = "CameraSettings", menuName = ("Player/Camera/CameraSettings"))]
 public class CameraSettings : ScriptableObject
 {
   public float SmoothTime;
   public Vector3 Offset;
 } 
}
