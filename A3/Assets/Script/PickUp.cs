using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
   public Transform theDest;
   Vector3 velocity;
   void OnMouseDown() // if mouse click
   {
       GetComponent<SphereCollider>().enabled = false; //cancel the sphere collider
       GetComponent<Rigidbody>().useGravity = false; // cancel the gravity
       GetComponent<Rigidbody>().freezeRotation = true; // cancel the rotation
       GetComponent<Rigidbody>().velocity = velocity; // cancel the velocity
       this.transform.position = theDest.position; // transform to the destination
       this.transform.parent = GameObject.Find("Destination").transform; // get where the destination is been set
        
   }
   void OnMouseUp() // if mouse release
   {
       this.transform.parent = null; // cancel the destination 
       GetComponent<Rigidbody>().freezeRotation = false; // enable the rotation
       GetComponent<Rigidbody>().useGravity = true; // enable the gravity
       GetComponent<SphereCollider>().enabled = true; // enable the sphere collider
   }
}
