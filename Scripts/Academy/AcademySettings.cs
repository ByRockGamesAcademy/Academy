using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Academy 
{
 [CreateAssetMenu (fileName = "AcademySettings", menuName =("Academy/AcademySettings"))]  
 public class AcademySettings : ScriptableObject
 {
  [Header("Player Speed")]
   public int Speed;
 }
 
}
