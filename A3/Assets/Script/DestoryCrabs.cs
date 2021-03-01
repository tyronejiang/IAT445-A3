using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryCrabs : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.name == "Crab")
        {
            Destroy(col.gameObject);
        }
    }
}
