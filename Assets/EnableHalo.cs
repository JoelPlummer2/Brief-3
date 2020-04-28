using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableHalo : MonoBehaviour
{

 
     public Behaviour halo;
     void Start () {
             }
     
     void OnTriggerEnter(Collider other) {
         if (other.tag == "Player")
             halo.enabled = false;
     }
 void OnTriggerExit(Collider other) {
         if (other.tag == "Player")
             halo.enabled = true;
 }
}
