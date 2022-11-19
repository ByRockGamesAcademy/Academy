using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
 public class PlayerController : MonoBehaviour
 {
   [Header("Player Settings Script")]
   [SerializeField]private PlayerSettings PlayerSettings; 
   [SerializeField]private FloatingJoystick Joystick; 
   Rigidbody rigid;   
   Vector3 Move;
   private void Start() 
   {
     rigid = GetComponent<Rigidbody>();
   }
   private void FixedUpdate() 
   {
     Move = Vector3.zero;
     Move.x = Joystick.Horizontal * PlayerSettings.Speed * Time.deltaTime;
     Move.z = Joystick.Vertical * PlayerSettings.Speed * Time.deltaTime;

     if(Joystick.Horizontal != 0 || Joystick.Vertical !=0)
     {
        Vector3 Direction = Vector3.RotateTowards(this.transform.forward, Move, PlayerSettings.RotateSpeed * Time.deltaTime, 0.0f);
        this.transform.rotation = Quaternion.LookRotation(Direction);

        Player.AnimatorController.instance.RunTrue();
     }
     else if(Joystick.Horizontal == 0 && Joystick.Vertical == 0)
     {
       Player.AnimatorController.instance.RunFalse();
     }

     rigid.MovePosition(rigid.position + Move);
   }
 }
}


