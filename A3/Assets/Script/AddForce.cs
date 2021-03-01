using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public float forceAmount = 1000f;

    void OnControllerColliderHit (ControllerColliderHit col)
    {
        
        GetComponent<Rigidbody>().AddForce(-transform.forward*forceAmount, ForceMode.Acceleration);
        GetComponent<Rigidbody>().useGravity=true;
    }
}
