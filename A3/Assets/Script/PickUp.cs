using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   public Transform theDest;
   
   void OnMouseDown()
   {
       GetComponent<BoxCollider>().enabled = false;
       GetComponent<Rigidbody>().useGravity = false;
       GetComponent<Rigidbody>().freezeRotation = true;
       
       this.transform.position = theDest.position;
       this.transform.parent = GameObject.Find("Destination").transform;
   }
   void OnMouseUp()
   {
       this.transform.parent = null;
       GetComponent<Rigidbody>().freezeRotation = false;

       GetComponent<Rigidbody>().useGravity = true;
       GetComponent<BoxCollider>().enabled = true;
   }
}
