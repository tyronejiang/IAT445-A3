using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyGate : MonoBehaviour
{
   
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        GameObject[] gates = GameObject.FindGameObjectsWithTag("gate");
        foreach(GameObject gate in gates)
        GameObject.Destroy(gate);
        
    }
    
}
