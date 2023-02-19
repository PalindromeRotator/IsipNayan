using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 
 public class BGmusic : MonoBehaviour
 {
     private static BGmusic instance = null;
     public static BGmusic Instance
     {
         get { return instance; }
     }
     void Awake()
     {
         if (instance != null && instance != this)
         {
             Destroy(this.gameObject);
         }
         else
         {
             instance = this;
         }
         DontDestroyOnLoad(this.gameObject);
         
     }

 }