using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Player
{
 public class CollisionController : MonoBehaviour
 {
   [Header("Score")]
   [SerializeField]private int Score;
   [SerializeField]private TMP_Text ScoreText;

   private void OnCollisionEnter(Collision other) 
   {
    if(other.gameObject.CompareTag("Cube"))
    {
      Score ++;
      ScoreText.text = "" + Score.ToString();
    }
   }
 } 
}
