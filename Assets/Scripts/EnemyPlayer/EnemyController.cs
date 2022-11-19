using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace EnemyPlayer
{
 public class EnemyController : MonoBehaviour
 {
   private NavMeshAgent Agent;

   [Header("Target Player")]
   [SerializeField]private Transform TargetPlayer;

   private void Start() 
   {
     Agent = GetComponent<NavMeshAgent>();
   }

   private void FixedUpdate() 
   {
     Agent.SetDestination(TargetPlayer.position);
   }
 } 
}

