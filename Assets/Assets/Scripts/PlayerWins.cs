using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

 public class PlayerWins : MonoBehaviour
 {
     [SerializeField] private Canvas canvas;

     void OnTriggerEnter(Collider other) {

         if(other.gameObject.CompareTag("Player")) {

             canvas.gameObject.SetActive(true);
         }
     }
 }