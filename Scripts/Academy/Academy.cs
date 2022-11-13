using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Academy
{
 public class Academy : MonoBehaviour
 {
   public static Academy instance;

    [Header("Player Settings")]
    [SerializeField]private AcademySettings AcademySettings;
    
    [Header("Veria.")]
    public int Number;
    private void Start() 
    {
       if(instance == null)
       {
         instance = this;
       }
      
    }
 }
}
