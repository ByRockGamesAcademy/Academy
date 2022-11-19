using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Player
{
 public class CollisionController : MonoBehaviour
 {
    private void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.CompareTag("Cube"))
        {
           other.gameObject.SetActive(false);
           GameManager.instance.CollectCube++;
           GameManager.instance.CollectedCubeText.text = "" + GameManager.instance.CollectCube.ToString();
        } 
    }
 } 
}

