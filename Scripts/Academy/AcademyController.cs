using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Control
{
 public class AcademyController : MonoBehaviour
 {
    private void Start() 
    {
         
    }
    public void BuutonController()
    {
      Academy.Academy.instance.Number += 4;
    }
 }
 
}
