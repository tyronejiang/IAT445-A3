using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoconutFall : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
       
        GetComponent<Rigidbody>().isKinematic = false;
    }
}
