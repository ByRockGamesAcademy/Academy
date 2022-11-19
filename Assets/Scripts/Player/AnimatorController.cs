using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
 [RequireComponent(typeof(Animator))]
 public class AnimatorController : MonoBehaviour
 {
   public static AnimatorController instance;
   Animator anim;
   private void Awake() 
   {
     anim = GetComponent<Animator>();
   }
   
   private void Start() 
   {
     if(instance == null)
     {
        instance = this;
     }
   }
   public void RunTrue()
   {
      anim.SetBool("Run", true);
   }

   public void RunFalse()
   {
      anim.SetBool("Run", false);
   }
 }  
}

