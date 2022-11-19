using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [Header("Canvas UI")]
    public int CollectCube;
    public TMP_Text CollectedCubeText;
    private void Awake() 
    {
       if(instance == null)
       {
         instance = this;
       }  
    }
  
}
