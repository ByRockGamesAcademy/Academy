using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
 [CreateAssetMenu (fileName = "PlayerSettings", menuName =("Player/PlayerSettings"))]
 public class PlayerSettings : ScriptableObject
 {
    [Header("Player Speed")]
    public int Speed;    
    public int RotateSpeed;
 }
}

