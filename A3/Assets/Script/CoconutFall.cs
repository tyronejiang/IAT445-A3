using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutFall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) // check if player enter the coconuttrigger
    {
       
        GetComponent<Rigidbody>().isKinematic = false; // make coconut fall down
    }
}
